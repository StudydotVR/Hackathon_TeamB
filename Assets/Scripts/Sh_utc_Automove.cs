using UnityEngine;
using System.Collections;

public class Sh_utc_Automove : MonoBehaviour {
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.velocity = new Vector3(0,0,5);
    }
}
