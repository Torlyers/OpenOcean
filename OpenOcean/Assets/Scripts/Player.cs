using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player Instance;

    public int Life;
    public int Wealth;
    public int Fuel;

    private void Awake()
    {
        Instance = this;
    }

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Jet()
    {

    }

    public void Rotate(bool AngDirec)//1 for clockwise
    {

    }




}
