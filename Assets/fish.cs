using UnityEngine;
using System.Collections;

public class fish : MonoBehaviour {

	private float speed;
	private Vector3 destination;
	//private Rigidbody rb;

	private float rotationSmooth;


	void Start () {
		//rb = GetComponent<Rigidbody>();
		speed = 10f;

		destination = GetRandomDestination();

		rotationSmooth = 0.5f;


	}


	void Update () {
		if(Vector3.Distance(destination, transform.position) < 1f) {
			destination = GetRandomDestination();
		}
		//transform.LookAt(destination);
		//transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
		//rb.velocity = Vector3.forward * speed;
		Quaternion targetRotation = Quaternion.LookRotation(destination - transform.position);
    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

		transform.Translate(Vector3.forward * speed * Time.deltaTime);

		//transform.position = Vector3.Lerp(transform.position, destination, speed * Time.deltaTime);

	}

	public Vector3 GetRandomDestination() {
		return destination = new Vector3(Random.Range(40f, 70f), 4f, Random.Range(150f, 180f));
		//return destination = new Vector3(Random.Range(25f, 30f), 3f, Random.Range(-10f, 10f));
	}
}
