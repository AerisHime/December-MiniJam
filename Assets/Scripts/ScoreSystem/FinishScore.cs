using UnityEngine;
using System.Collections;

public class FinishScore : MonoBehaviour {

    MainScore mainScore;
    float highScore = 0;
    // Use this for initialization
	void Start () {
        mainScore = this.GetComponent<MainScore>();
        if (PlayerPrefs.GetFloat("High Score") != null)
        {
            highScore = PlayerPrefs.GetFloat("High Score");
        }
        else
            PlayerPrefs.SetFloat("High Score", highScore);
	}
	
    public void HandleScore(float achievedScore)
    {
        if (achievedScore <= highScore)
        {
            NoNewHighScore();
        }
        else
            NewHighScore(achievedScore);

    }
    void NewHighScore(float newScore)
    {
        //updating the saved HighScore with the new value
        PlayerPrefs.SetFloat("High Score", newScore);

        //TODO: display "you have achieved a new highscore
    }

    void NoNewHighScore()
    {

        //to do: display text "unlucky"
    }

}
