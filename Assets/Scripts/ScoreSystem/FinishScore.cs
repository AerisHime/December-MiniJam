using UnityEngine;
using System.Collections;

public class FinishScore : MonoBehaviour {

    MainScore mainScore;
    float highScore = 0;
    // Use this for initialization
	void Start () {
        mainScore = this.GetComponent<MainScore>();
        if (!PlayerPrefs.HasKey("High Score"))
        {
            PlayerPrefs.SetFloat("High Score", highScore);

            
        }
        else
            highScore = PlayerPrefs.GetFloat("High Score");
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
