using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour {

    public static GameMain Instance;
    public Vector3 StartPosition;
    public int TotalWealth;

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
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void GameStart()
    {

    }


    public void GameOver()
    {

    }

    public void ResetGame()
    {
        ResetPlayer();
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
    }

}
