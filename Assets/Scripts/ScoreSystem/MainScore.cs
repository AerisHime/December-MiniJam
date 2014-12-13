using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainScore : MonoBehaviour {

    public Text ScoreText;
    SessionActive sessionActivity;
    public float initialScore = 10000;
    public float Score;
    public float decreaserate = 50;
	// Use this for initialization
	void Start () {
        sessionActivity = this.GetComponent<SessionActive>();
        Score = initialScore;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (sessionActivity.CheckState())
        {
            Score -= decreaserate * Time.deltaTime;
            ScoreText.text = Score.ToString();
            
        }
    }
   public void ResetScore()
      {
          Score = initialScore;
      }

	
}
