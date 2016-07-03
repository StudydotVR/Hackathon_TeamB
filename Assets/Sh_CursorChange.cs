using UnityEngine;
using System.Collections;

public class Sh_CursorChange : MonoBehaviour {
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public GameObject K;
    float hogehoge; 

    // Use this for initialization
    void Start () {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        //hogehoge = K.GetComponent<Sh_UIOp>().timer; 
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }*/
        hogehoge = K.GetComponent<Sh_UIOp>().timer;
        if (hogehoge <= -1)
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
    }
}
