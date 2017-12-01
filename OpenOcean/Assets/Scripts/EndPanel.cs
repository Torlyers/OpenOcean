using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Restart()
    {
        GameMain.Instance.ResetGame();
    }
    
    public void BackToStart()
    {
        GameMain.Instance.SetMenu();
    }
}
