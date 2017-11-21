using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public ItemCat ItemClass;
    public int Value;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(ItemClass == ItemCat.Chest || ItemClass == ItemCat.Coin)
            {
                Player.Instance.Wealth += Value;
            }
            else if(ItemClass == ItemCat.fuelCan)
            {
                Player.Instance.Fuel += Value;
            }
        }
    }

    public enum ItemCat
    {
        Coin,
        Chest,
        fuelCan
    }


}

