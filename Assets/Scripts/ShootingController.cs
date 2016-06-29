/// <summary>
/// Playerから弾を打つためのスクリプト．Spaceを押すと弾が打てる
/// ※注意：弾にはRigidbodyがついてないとダメ！！
/// </summary>


using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour
{
    public GameObject shotObj;          //飛ばす弾，Inspecterからオブジェクト突っ込むだけ
    
    private int layerMask;              //一応作ったけどなくってもいい．指定したレイヤーにしかRayが当たらないようにする
                                        //レイヤーはInspectorの上の方，タグの横で指定する

    private float camRayLength = 100;   //Rayの長さ，短いと遠くのものに当たらなくなる


    void Start()
    {
        layerMask = LayerMask.GetMask("Target");
    }


    void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(camRay.origin, camRay.direction * 50, Color.yellow);  //実行時SceneにRayを描画する

        RaycastHit hit;
        if (Physics.Raycast(camRay, out hit, camRayLength, layerMask))
        {
            Vector3 shotVector = hit.point - transform.position;        //Playerから球を打つ目的地へのベクトル
            transform.rotation = Quaternion.LookRotation(shotVector);   //Playerを目的地の角度へ回転させる

            if(Input.GetKeyDown(KeyCode.Space))
            {
                //指定した弾をインスタンス化し，そのオブジェクトをshotに受け取る
                GameObject shot = Instantiate(shotObj, transform.position + transform.forward * 2, Quaternion.LookRotation(transform.forward)) as GameObject;
                //shotにつけられたRigidbodyを使ってAddForceで指定方向に飛ばす
                shot.GetComponent<Rigidbody>().AddForce(shotVector * 50);
            }
        }
    }
}
