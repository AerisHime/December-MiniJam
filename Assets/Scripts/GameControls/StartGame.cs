﻿using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    public GameObject playerObject;
    SessionActive isActive;
    MainScore mainScore;
    UIHandler uiSystem;
    // Use this for initialization
	void Start () {
        isActive = this.GetComponent<SessionActive>();
        mainScore = this.GetComponent<MainScore>();
        uiSystem = this.GetComponent<UIHandler>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void StartSession()
    {
        playerObject.SetActive(true);
        isActive.Running();
        mainScore.ResetScore();
        uiSystem.StartButton.gameObject.SetActive(false);
        uiSystem.ScoreInterface.SetActive(true);
        uiSystem.ScoreText.SetActive(true);

    }
    public void RestartSession()
    {
        Application.LoadLevel(0);
    }
}
