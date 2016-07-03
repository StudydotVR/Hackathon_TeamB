using UnityEngine;
using System.Collections;

public class Sh_For_Start : MonoBehaviour {

    public void SceneLoad()
    {

        FadeManager.Instance.LoadLevel("Proto2", 2);
    }
    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
