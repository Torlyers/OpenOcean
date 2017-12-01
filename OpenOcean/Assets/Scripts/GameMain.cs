using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour {

    public static GameMain Instance;
    public Vector3 StartPosition;
    public int TotalWealth;
    public MainCanvas mainCanvas;

    private Player player;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        TotalWealth = 0;
        player = Player.Instance;
        SetMenu();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SetMenu()
    {
        mainCanvas.CloseAllPanels();
        mainCanvas.OpenPanel(mainCanvas.StartPanel);
    }

    public void GameStart()
    {        
        mainCanvas.CloseAllPanels();
        mainCanvas.SwitchPanel(mainCanvas.StartPanel, mainCanvas.MainPanel);
    }

    public void GameOver()
    {
        mainCanvas.SwitchPanel(mainCanvas.MainPanel, mainCanvas.EndPanel);
    }

    public void ResetGame()
    {
        ResetPlayer();
        player.Life = 3;
        player.TotalWealth = 0;        
    }

    public void ResetPlayer()
    {
        player.gameObject.SetActive(true);
        player.transform.position = StartPosition;
        player.Life -= 1;
        if (player.Life == 0)
            player.Life = 3;        
        player.animator.SetInteger("Life", player.Life);
        player.animator.SetBool("isDangerSpeed", false);
        player.Wealth = 0;
    }

}
