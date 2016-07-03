using UnityEngine;
using System.Collections;

public class YellowTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == "S") {
			Destroy(this.gameObject);
		}
	}
}
