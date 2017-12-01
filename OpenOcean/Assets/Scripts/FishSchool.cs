using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSchool : MonoBehaviour {

    float offset;
    
    // Use this for initialization
	void Start ()
    {
        offset = 0.01f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += new Vector3(offset, 0, 0);
        if (transform.position.x >= 8 || transform.position.x <= -8)
            offset *= -1f;
	}
}
