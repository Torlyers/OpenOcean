using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainPanel : MonoBehaviour {

    public Text wealthText;
    public List<Image> LifeIcons;
    public Image FuelBarFill;

    public Sprite LifeOn;
    public Sprite LifeOff;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        wealthText.text = "$" + Player.Instance.Wealth + "M";
        FuelBarFill.fillAmount = Player.Instance.Fuel / Player.Instance.MaxFuel;
        if(Player.Instance.Life == 2)
        {
            LifeIcons[0].sprite = LifeOff;
        }
        else if(Player.Instance.Life == 1)
        {
            LifeIcons[1].sprite = LifeOff;
        }
        else if(Player.Instance.Life == 3)
        {
            LifeIcons[1].sprite = LifeOn;
            LifeIcons[0].sprite = LifeOn;
        }
	}
}
