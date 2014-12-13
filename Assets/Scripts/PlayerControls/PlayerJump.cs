using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {

    public Vector2 jumpHeight;
    bool canJump;
	void Start () {
        canJump = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (canJump && (Input.GetMouseButtonDown(0)||Input.GetKeyDown("space") ))
        {
           // rigidbody2D.velocity = jumpHeight;
            rigidbody2D.AddForce(jumpHeight*50);
        }

	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            canJump = true;            
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }

}
