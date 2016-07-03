using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TIMETEXT : MonoBehaviour {
    Text text;
    public float timer = 60;

    // Use this for initialization
    void Start () {
        text = gameObject.GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        text.text = "TIME:" + string.Format("{0:f2}\r",timer);

        


    }
}
