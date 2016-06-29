/// <summary>
/// これがつけられたオブジェクトは一定時間後に勝手に消える
/// lifeTimeを変えると消えるまでの時間を変えられる
/// </summary>


using UnityEngine;
using System.Collections;

public class SetLifeTime : MonoBehaviour
{
    public float lifeTime = 3f;
	
	void Start ()
    {
        Destroy(gameObject, lifeTime);
	}
}
