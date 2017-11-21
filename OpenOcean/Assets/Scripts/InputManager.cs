using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Player.Instance.Rotate(false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Player.Instance.Rotate(true);
        }

        if (Input.GetKey(KeyCode.J))
        {
            Player.Instance.Jet();
        }
	}
}
