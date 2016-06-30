using UnityEngine;
using System.Collections;

public class Sh_Shooting : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //マウスのx,y座標を取得
        Vector3 vecMouse = Input.mousePosition;
        //ワールド座標に変換じゃ！！
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
        
        
    }
}
