using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {

	public float speed = 1.0f;
	Rigidbody rb;


	void Start () {
		rb = GetComponent<Rigidbody>();

	}


	void Update () {
		Vector3 move = new Vector3(0,0,1);
		rb.velocity = move * speed;

	}
}
