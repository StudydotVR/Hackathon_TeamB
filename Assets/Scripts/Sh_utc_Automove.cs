using UnityEngine;
using System.Collections;

public class Sh_utc_Automove : MonoBehaviour {
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //rb.velocity = new Vector3(0,0,5);
        transform.position = transform.position + new Vector3(0, 0, 5 * Time.deltaTime);
    }
}
