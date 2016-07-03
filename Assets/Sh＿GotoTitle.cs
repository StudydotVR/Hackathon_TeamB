using UnityEngine;
using System.Collections;

public class Sh＿GotoTitle : MonoBehaviour {
    public void LoadScene3()
    {
        FadeManager.Instance.LoadLevel("Sh_Title", 2);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
