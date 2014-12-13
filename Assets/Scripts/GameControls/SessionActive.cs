using UnityEngine;
using System.Collections;

public class SessionActive : MonoBehaviour {

    bool gameRunning = false;
    // Use this for initialization

    public void Running()
    {
        gameRunning = true;
        Time.timeScale = 1.0f;
    }

    public void StopRunning()
    {
        gameRunning = false;
    }

    public bool CheckState()
    {
        return gameRunning;
    }

}
