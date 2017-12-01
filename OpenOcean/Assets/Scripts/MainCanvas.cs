using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvas : MonoBehaviour {

    public GameObject StartPanel;
    public GameObject MainPanel;
    public GameObject EndPanel;
    public GameObject ScorePanel;
    
    // Use this for initialization
	void Start ()
    {
        StartPanel.SetActive(true);
        MainPanel.SetActive(false);
        EndPanel.SetActive(false);
        ScorePanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchPanel(GameObject lastPanel, GameObject nextPanel)
    {
        ClosePanel(lastPanel);
        OpenPanel(nextPanel);
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void CloseAllPanels()
    {
        StartPanel.SetActive(false);
        MainPanel.SetActive(false);
        EndPanel.SetActive(false);
        ScorePanel.SetActive(false);
    }
}
