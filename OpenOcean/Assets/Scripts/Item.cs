using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    public ItemCat ItemClass;
    public int Value;    

	// Use this for initialization
	void Start ()
    {
        if (ItemClass == ItemCat.Chest)
        {
            Text MoneyText;
            MoneyText = gameObject.GetComponentInChildren<Text>();
            MoneyText.text = Value.ToString();
        }

        else if(ItemClass == ItemCat.Tomb)
        {
            Text MoneyText;
            MoneyText = gameObject.GetComponentInChildren<Text>();
            MoneyText.text = Player.Instance.Wealth.ToString();
        } 
            
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            GameMain.Instance.audioSource.PlayOneShot(GameMain.Instance.audioClips[0]);

            if (ItemClass == ItemCat.Chest || ItemClass == ItemCat.Coin)
            {
                Player.Instance.Wealth += Value;
            }
            else if(ItemClass == ItemCat.fuelCan)
            {
                Player.Instance.Fuel += Value;
            }

            gameObject.SetActive(false);
        }
    }

    public enum ItemCat
    {
        Coin,
        Chest,
        fuelCan,
        Tomb
    }


}

