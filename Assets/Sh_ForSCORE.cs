using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sh_ForSCORE : MonoBehaviour {
    public int Scorename;
    public Sh_UIOp XX;
    public Text TETE;

	// Use this for initialization
	void Start () {
        Scorename = Sh_UIOp.count;//XX.GetComponent<Sh_UIOp>().SCORE;
        Debug.Log(Scorename);
        SetScorename();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    void SetScorename()
    {
        TETE.text = "SCORE : " + Scorename.ToString();
    }
}
