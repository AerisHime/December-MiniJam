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

        if (canJump && Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = jumpHeight;
        }

	}

    void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        canJump = false;
    }

}
