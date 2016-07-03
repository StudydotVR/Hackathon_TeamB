
using UnityEngine;
using System.Collections;

public class enemyMotion : MonoBehaviour {

	private float speed;
	private float range;
	private Vector3 destination;
	private Vector3 destinationHigh;
	private Vector3 destinationLow;
	private bool up;
	private Rigidbody rb;
	private float currentTime;

	void Start () {
		rb = GetComponent<Rigidbody>();
		currentTime = 0;

		speed = Random.Range(2f, 4f);
		range = 4f;
		destinationHigh = new Vector3(transform.position.x, transform.position.y + range, transform.position.z);
		destinationLow = new Vector3(transform.position.x, transform.position.y - range, transform.position.z);
		destination = destinationHigh;
		up = true;

	}

	void Update () {
		currentTime += Time.deltaTime;
		if(up) {
			rb.velocity = Vector3.up * speed;
			if(Vector3.Distance(destination, transform.position) < 1f) {
				destination = destinationLow;
				up = false;
			}
		}

		if(!up) {
			rb.velocity = Vector3.down * speed;
			if(Vector3.Distance(destination, transform.position) < 1f) {
				destination = destinationHigh;
				up = true;
			}
		}

		if(currentTime > 20f) {
			Destroy(this.gameObject);
		}
	}

}
