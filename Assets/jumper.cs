using UnityEngine;
using System.Collections;

public class jumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			other.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 1200);
		}


	}
}
