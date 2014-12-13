using UnityEngine;
using System.Collections;

public class SessionActive : MonoBehaviour {

    bool gameRunning = true;
    // Use this for initialization

    public void Running()
    {
        gameRunning = true;
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
