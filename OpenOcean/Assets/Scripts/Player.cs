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
    private Rigidbody2D Rb2D;

    private void Awake()
    {
        Instance = this;
    }

    void Start ()
    {
        Fuel = MaxFuel;
        speed = 0;
        Rb2D = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        Fuel -= FuelConsumeRate * Time.deltaTime;
        speed = (int)(Rb2D.velocity.magnitude * 10);
	}

    public void Jet()
    {

    }

    public void Rotate(bool AngDirec)//1 for clockwise
    {

    }

    




}
