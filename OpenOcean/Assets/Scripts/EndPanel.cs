using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour {

    public Text final_score;

    private void OnEnable()
    {
        final_score.text = "$" + Player.Instance.Wealth + "M";
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Restart()
    {
        GameMain.Instance.GameStart();
    }
    
    public void BackToStart()
    {
        GameMain.Instance.SetMenu();
    }
}
