using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainScore : MonoBehaviour {

    public Text ScoreText;
    
    public float Score = 10000;
    public float decreaserate = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        Score -= decreaserate*Time.deltaTime;
        ScoreText.text = Score.ToString();

	}
}
