using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour {

    public static GameMain Instance;
    public Vector3 StartPosition;

    public int TotalWealth;


    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        TotalWealth = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


}
