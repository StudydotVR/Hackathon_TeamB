using UnityEngine;
using System.Collections;

public class Ag : MonoBehaviour {

	private int speed;
	public GameObject Spark;
	public GameObject RedSpark;
	private Vector3 hitPos;
	GameObject scoreCanvas;

	// Use this for initialization
	void Start () {
		speed = 30;
		scoreCanvas = GameObject.Find( "Canvas" );
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		hitPos = other.ClosestPointOnBounds(this.transform.position);

		if(other.tag == "Cl") {
			Sh_UIOp.count += 100;
			GameObject before = GameObject.Find("Ag");
			//before.SetActiveRecursively(false);
			before.SetActive(false);

			GameObject after = transform.Find("AgCl").gameObject;
			after.SetActiveRecursively(true);

			GetComponent<enemyMotion>().enabled = false;
			GetComponent<Rigidbody>().velocity = Vector3.down * speed;

			Instantiate(Spark, transform.position, transform.rotation);
		} else if(other.tag == "SO") {
			Sh_UIOp.count -= 100;
			Instantiate(RedSpark, hitPos, transform.rotation);
		} else if(other.tag == "S"){
			Sh_UIOp.count -= 100;
			Instantiate(RedSpark, hitPos, transform.rotation);
		}
		Debug.Log(Sh_UIOp.count);
		Sh_UIOp scoreText = scoreCanvas.GetComponent<Sh_UIOp>();
		scoreText.SetCountText();
	}
}
