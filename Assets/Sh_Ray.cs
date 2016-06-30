using UnityEngine;
using System.Collections;

public class Sh_Ray : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        //メインカメラ上のマウスカーソルのある位置からRayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            //Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
            Debug.Log(hit.collider.gameObject.name);
            //ワールド座標を取得

            if (Input.GetMouseButtonDown(0))
            {
                //hit.collider.enabled = false;
                
            }
        }
        // 4.		
        // 球形のRayをとばす
        if (Physics.SphereCast(ray, 5.0f, out hit, 10.0f)) { }

        // 5.		
        // Rayの可視化
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 3.0f);
    }
}
