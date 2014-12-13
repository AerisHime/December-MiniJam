using UnityEngine;
using System.Collections;

public class PlayerSlow : MonoBehaviour {

    public Vector2 speedDown = new Vector2(-400f, 400f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       //for testing the deceleration
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Hit button");

            rigidbody2D.AddForce(speedDown, ForceMode2D.Impulse);
        }
	
	}
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Slower")
        {
            this.rigidbody2D.AddForce(speedDown, ForceMode2D.Impulse);

            Destroy(otherObj.gameObject);
        }
    }
}
