/// <summary>
/// これがつけられたオブジェクトは一定時間後に勝手に消える
/// lifeTimeを変えると消えるまでの時間を変えられる
/// 何かに当たると消える
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

  void OnTriggerEnter(Collider other) {
    if(other.tag == "Blue") {
      Destroy(this.gameObject);
    } else if(other.tag == "Red") {
      Destroy(this.gameObject);
    } else if(other.tag == "Yellow") {
      Destroy(this.gameObject);
    }
  }
}
