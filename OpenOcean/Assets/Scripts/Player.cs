using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour {

    public static Player Instance;

   // [HideInInspector]
    public int Life;

    [HideInInspector]
    public int Wealth;
    [HideInInspector]
    public int TotalWealth;

    public float MaxFuel;
    [HideInInspector]
    public float Fuel;

    [HideInInspector]
    public int FuelConsumeRate;
    public int MaxConsumeRate;

    [HideInInspector]
    public int speed;
    public int DangerSpeed;
    private Rigidbody2D Rb2D;


    public float Force;
    public float AngForce;

    public float rotate;
    public float radius;

    public ParticleSystem JetParticle;
    [HideInInspector]
    public Animator animator;
    public GameObject SpeedUI;
    public GameObject ExplosionSS;
    public GameObject Tomb;

    private void Awake()
    {
        Instance = this;
    }

    void Start ()
    {
        Life = 3;
        Fuel = MaxFuel;
        speed = 0;
        rotate = 0;
        Rb2D = GetComponent<Rigidbody2D>();
        JetParticle.Simulate(0);
        animator = GetComponent<Animator>();
        FuelConsumeRate = 0;
        
	}
	
	void Update ()
    {
        Fuel -= FuelConsumeRate * Time.deltaTime;
        speed = (int)(Rb2D.velocity.magnitude * 10);
        rotate = transform.eulerAngles.z;
        if (rotate > 180f)
            rotate -= 360f;
        radius = rotate * Mathf.PI / 180f;

        if (speed > DangerSpeed)
        {
            animator.SetBool("isDangerSpeed", true);
        }
        else
        {
            animator.SetBool("isDangerSpeed", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Rotate(false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Rotate(true);
        }

        if (Input.GetKey(KeyCode.J))
        {
            if (Fuel > 0) 
                Jet();
        }

        if (Input.GetKeyUp(KeyCode.J) || Fuel <= 0)
        {
            StopJet();
        }

        if(Input.touchCount != 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (Fuel > 0)
                Jet();
        }

        if (Input.touchCount != 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            StopJet();
        }

    }

    void Jet()
    {

        Rb2D.AddForce(new Vector2(-Mathf.Sin(radius) * Force, Mathf.Cos(radius) * Force));
        if (!JetParticle.isPlaying)
        {
            JetParticle.Simulate(0);
            JetParticle.Play();
        }
        FuelConsumeRate = MaxConsumeRate;

    }

    void StopJet()
    {
        JetParticle.Stop();
        FuelConsumeRate = 0;
    }

    void Rotate(bool AngDirec)//1 for clockwise
    {
        if(!AngDirec)
        {
            //transform.eulerAngles += new Vector3(0, 0, 2f);
            Rb2D.AddTorque(AngForce);
        }
        else
        {
            //transform.eulerAngles += new Vector3(0, 0, -2f);
            Rb2D.AddTorque(-AngForce);
        }
    }

    public void Crash()
    {
        var item= Instantiate(ExplosionSS);
        item.transform.position = transform.position;
        GameMain.Instance.MainCamera.DOShakePosition(0.3f); 

        gameObject.SetActive(false);         
        
        if (Life > 1)
        {
            SetTomb();
            Invoke("Reset", 1);  
        }
        else
        {
            Invoke("GameOver", 1);
        }
    }

    public void SetTomb()
    {
        var tomb = Instantiate(Tomb);
        tomb.transform.position = transform.position;
        
    }

    private void GameOver()
    {
        GameMain.Instance.GameOver();
    }

    private void Reset()
    {
        GameMain.Instance.ResetPlayer();
    }   

}
