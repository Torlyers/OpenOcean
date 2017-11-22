using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player Instance;

    public int Life;
    public int Wealth;
    public float MaxFuel;
    public float Fuel;

    public int FuelConsumeRate;

    public int speed;
    public int DangerSpeed;
    private Rigidbody2D Rb2D;

    public float Force;
    public float AngForce;

    private float rotate;

    public ParticleSystem JetParticle;
    public Animator animator;

    private void Awake()
    {
        Instance = this;
    }

    void Start ()
    {
        Fuel = MaxFuel;
        speed = 0;
        rotate = 0;
        Rb2D = GetComponent<Rigidbody2D>();
        JetParticle.Simulate(0);
        animator = GetComponent<Animator>();
        
	}
	
	void Update ()
    {
        Fuel -= FuelConsumeRate * Time.deltaTime;
        speed = (int)(Rb2D.velocity.magnitude * 10);
        rotate = gameObject.transform.eulerAngles.z;

        if(speed > DangerSpeed)
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
            Jet();
        }

        if(Input.GetKeyUp(KeyCode.J))
        {
            StopJet();
        }
    }

    void Jet()
    {
        Rb2D.AddForce(new Vector2(Mathf.Sin(rotate) * Force, Mathf.Cos(rotate) * Force));
        if (!JetParticle.isPlaying)
        {
            JetParticle.Simulate(0);
            JetParticle.Play();
        }

    }

    void StopJet()
    {
        JetParticle.Stop();
    }

    void Rotate(bool AngDirec)//1 for clockwise
    {
        if(!AngDirec)
        {
            Rb2D.AddTorque(AngForce);
        }
        else
        {
            Rb2D.AddTorque(-AngForce);
        }
    }

    public void Crash()
    {
        Debug.Log("Crash");
        StopJet();
        gameObject.SetActive(false);
        if (Life > 1)
        {
            Invoke("Reset", 1);  
        }
        else
        {
            Invoke("GameOver", 1);
        }
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
