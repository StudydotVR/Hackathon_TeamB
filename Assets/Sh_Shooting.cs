using UnityEngine;
using System.Collections;

public class Sh_Shooting : MonoBehaviour {
    private int i =3;
    public GameObject shotObj1;//Cl
    public GameObject shotObj2;//SO4
    public GameObject shotObj3;//S

    public int speed;

    private GameObject shotObj;

    private int layerMask;
    private float camRayLength = 100;

    // Use this for initialization
    void Start () {
        //layerMask = LayerMask.GetMask("Target");
        shotObj = shotObj3;
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(1))
        {
            i++;

            if(i >= 3)
            {
                i = 0;
            }
            if (i % 3 == 0)
            {
                shotObj = shotObj1;
            }
            if (i % 3 == 1)
            {
                shotObj = shotObj2;
            }
            if (i % 3 == 2)
            {
                shotObj = shotObj3;
            }


        }

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
                shot.GetComponent<Rigidbody>().AddForce(shotVector * speed);
            }
        }

    }
}
