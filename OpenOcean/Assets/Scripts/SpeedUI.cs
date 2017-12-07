using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedUI : MonoBehaviour {

    public Transform aim;
    public Text SpeedText;

    

	// Use this for initialization
	void Start ()
    {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.position = new Vector3(aim.position.x + 1, aim.position.y + 1, gameObject.transform.position.z);
        SpeedText.text = Player.Instance.speed.ToString();
        //gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
    
	}
}
