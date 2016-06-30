using UnityEngine;
using System.Collections;

public class Sh_Ray : MonoBehaviour {

    Vector3 lb, rt, lt, rb;
    public Transform center; // 四隅の深さを設定する用のオブジェクト

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
            //マウスの座標を取得
            Vector3 vecMouse = Input.mousePosition;
            //ワールド座標に変換
            Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
            
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
