using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform followObject;
	public float followSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 difference = (Vector2)followObject.position - (Vector2)this.transform.position;
		if (difference.magnitude>0.5f) {
			this.transform.position += (Vector3) difference * followSpeed / 200;
		}
	}
}
