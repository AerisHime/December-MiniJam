using UnityEngine;
using System.Collections;

public class LevelFinish : MonoBehaviour {
	SessionActive sessionActivity;
	public GameObject GameController ;
	
	// Use this for initialization
	void Start () {
		sessionActivity = GameController.GetComponent<SessionActive> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("vilocity" +rigidbody2D.velocity.ToString()) ;
	}
	
	void OnTriggerEnter2D(Collider2D otherObj)
	{
		if (otherObj.gameObject.tag == "Finish")
		{	
			//this.sessionActivity.StopRunning() ;
			// Play Finish Animation 
			sessionActivity.StopRunning() ;
			Time.timeScale = 0.0f ;
			
		}
	}
}

