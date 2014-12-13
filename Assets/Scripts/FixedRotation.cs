using UnityEngine;
using System.Collections;

public class FixedRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = Quaternion.FromToRotation(Vector3.zero, Vector3.zero);
	}
}
