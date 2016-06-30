using UnityEngine;
using System.Collections;

public class Sh_Shooting : MonoBehaviour {

    public GameObject shotObj1;
    public GameObject shotObj2;
    public GameObject shotObj3;

    private GameObject shotObj;


    private float camRayLength = 100;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(camRay.origin, camRay.direction * 50, Color.yellow);  //実行時SceneにRayを描画する

        RaycastHit hit;
        if (Physics.Raycast(camRay, out hit, camRayLength))
        {
            Vector3 shotVector = hit.point - transform.position;        //Playerから球を打つ目的地へのベクトル
            //transform.rotation = Quaternion.LookRotation(shotVector);   //Playerを目的地の角度へ回転させる
            

            if (Input.GetMouseButtonDown(0))
            //if (Input.GetKeyDown(KeyCode.Space))
            {
                //指定した弾をインスタンス化し，そのオブジェクトをshotに受け取る
                GameObject shot = Instantiate(shotObj, transform.position + transform.forward * 2, Quaternion.LookRotation(transform.forward)) as GameObject;
                //shotにつけられたRigidbodyを使ってAddForceで指定方向に飛ばす
                shot.GetComponent<Rigidbody>().AddForce(shotVector * 200);
            }
        }

    }
}
