using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainScore : MonoBehaviour {

    public Text ScoreText;
    SessionActive sessionActivity;
    public float Score = 10000;
    public float decreaserate = 50;
	// Use this for initialization
	void Start () {
        sessionActivity = this.GetComponent<SessionActive>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (sessionActivity.CheckState())
        {
            Score -= decreaserate * Time.deltaTime;
            ScoreText.text = Score.ToString();
            
        }

	}
}
