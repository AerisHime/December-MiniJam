using UnityEngine;
using System.Collections;

public class ChangeTexture : MonoBehaviour {

    public Sprite whole, broken;
    SpriteRenderer currentsprite;

	// Use this for initialization
	void Start () {

        
     currentsprite = transform.GetComponent<SpriteRenderer>();
//        sprite.sprite = whole;
	}

    public void BreakTexture()
    {

        Debug.Log("Hello");
        currentsprite.sprite = (Sprite)broken;
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = broken as Sprite;

    }

}
