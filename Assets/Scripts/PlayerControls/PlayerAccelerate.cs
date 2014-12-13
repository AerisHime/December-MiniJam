using UnityEngine;
using System.Collections;

public class PlayerAccelerate : MonoBehaviour {

    public Vector2 speedUp = new Vector2(250f, -250f);
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
       
        //for testing acceleration
        if (Input.GetKeyDown("d")) 
        {
            Debug.Log("Hit button");

            rigidbody2D.AddForce(speedUp, ForceMode2D.Impulse);
        }
	}
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Faster")
        {
            this.rigidbody2D.AddForce(speedUp, ForceMode2D.Impulse);

            Destroy(otherObj.gameObject);
        }
    }


}
