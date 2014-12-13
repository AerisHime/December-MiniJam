using UnityEngine;
using System.Collections;

public class IncreaseScore : MonoBehaviour {

    public float increaseValue = 100;
    MainScore mainScoreScript;
    void Start()
    {
        mainScoreScript = GetComponent<MainScore>();
    }
    public void Increase()
    {
        mainScoreScript.Score += increaseValue;
    }

}
