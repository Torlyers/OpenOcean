using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvas : MonoBehaviour {

    public GameObject StartPanel;
    public GameObject MainPanel;
    public GameObject EndPanel;
    
    // Use this for initialization
	void Start ()
    {
        StartPanel.SetActive(true);
        MainPanel.SetActive(false);
        EndPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchPanel(GameObject lastPanel, GameObject nextPanel)
    {
        lastPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}
