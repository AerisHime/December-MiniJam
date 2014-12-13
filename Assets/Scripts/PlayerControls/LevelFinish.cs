using UnityEngine;
using System.Collections;

public class LevelFinish : MonoBehaviour {
	SessionActive sessionActivity;
	public GameObject GameController ;
    UIHandler uiHandler;
	
	// Use this for initialization
	void Start () {
		sessionActivity = GameController.GetComponent<SessionActive> ();
        uiHandler = GameController.GetComponent<UIHandler>();
    }
	
	// Update is called once per frame
	void Update () {
		Debug.Log("vilocity" +rigidbody2D.velocity.ToString()) ;
	}
	
	void OnTriggerExit2D(Collider2D otherObj)
	{
		if (otherObj.gameObject.tag == "Finish")
		{	
			//this.sessionActivity.StopRunning() ;
			// Play Finish Animation 
			sessionActivity.StopRunning() ;
            uiHandler.StartButton.gameObject.SetActive(true);
			Time.timeScale = 0.0f ;
           
			
		}
	}
}

