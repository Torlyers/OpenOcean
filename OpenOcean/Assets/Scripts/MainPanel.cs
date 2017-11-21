using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainPanel : MonoBehaviour {

    public Text wealthText;
    public List<Image> LifeIcons;
    public Image FuelBarFill;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        wealthText.text = "$" + Player.Instance.Wealth + "M";
        FuelBarFill.fillAmount = Player.Instance.Fuel / Player.Instance.MaxFuel;
	}
}
