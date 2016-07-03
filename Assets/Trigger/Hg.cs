using UnityEngine;
using System.Collections;

public class Hg : MonoBehaviour {

	private int speed;
	public GameObject Spark;
	public GameObject RedSpark;
	private Vector3 hitPos;

	// Use this for initialization
	void Start () {
		speed = 16;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		hitPos = other.ClosestPointOnBounds(this.transform.position);
		
		if(other.tag == "Cl") {
			GameObject before = GameObject.Find("Hg");
			before.SetActiveRecursively(false);

			GameObject after = transform.Find("Hg2Cl2").gameObject;
			after.SetActiveRecursively(true);

			GetComponent<enemyMotion>().enabled = false;
			GetComponent<Rigidbody>().velocity = Vector3.down * speed;

			Instantiate(Spark, transform.position, transform.rotation);
		} else {
			Instantiate(RedSpark, hitPos, transform.rotation);
		}
	}
}
