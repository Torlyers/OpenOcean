using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour {

    public static GameMain Instance;
    public Vector3 StartPosition;
    public int TotalWealth;
    public MainCanvas mainCanvas;

    public Camera MainCamera;

    private Player player;

    public AudioSource audioSource;
    public List<AudioClip> audioClips;

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
        audioSource = GetComponent<AudioSource>();
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
        ResetGame();
        mainCanvas.CloseAllPanels();
        mainCanvas.SwitchPanel(mainCanvas.StartPanel, mainCanvas.MainPanel);        
    }

    public void GameOver()
    {
        mainCanvas.SwitchPanel(mainCanvas.MainPanel, mainCanvas.EndPanel);
        audioSource.Stop();
    }

    public void ResetGame()
    {
        ResetPlayer();
        player.Life = 3;
        player.TotalWealth = 0;
        audioSource.Play();        
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
        
        player.Fuel = player.MaxFuel;
    }

}
