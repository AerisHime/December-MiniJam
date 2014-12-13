using UnityEngine;
using System.Collections;

public class DecreaseScore : MonoBehaviour {

    public float decreaseValue = 100;
    MainScore mainScoreScript;
    void Start()
    {
        mainScoreScript = GetComponent<MainScore>();
    }
    public void Decrease()
    {
        mainScoreScript.Score -= decreaseValue;
    }
}
