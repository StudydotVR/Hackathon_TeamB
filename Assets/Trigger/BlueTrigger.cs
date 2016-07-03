using UnityEngine;
using System.Collections;

public class BlueTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Cl") {
			//before.SetActive(false);
			GameObject before = GameObject.Find("Ag");
			before.SetActiveRecursively(false);

			GameObject after = transform.Find("AgCl").gameObject;
			after.SetActiveRecursively(true);
			//Destroy(this.gameObject);
		}
	}
}
