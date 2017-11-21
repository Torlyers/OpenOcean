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

    private void Awake()
    {
        Instance = this;
    }

    void Start ()
    {
        Fuel = MaxFuel;
	}
	
	void Update ()
    {
        Fuel -= FuelConsumeRate * Time.deltaTime;
	}

    public void Jet()
    {

    }

    public void Rotate(bool AngDirec)//1 for clockwise
    {

    }

    




}
