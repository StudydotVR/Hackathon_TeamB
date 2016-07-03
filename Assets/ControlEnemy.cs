using UnityEngine;
using System.Collections;

public class ControlEnemy : MonoBehaviour {

  //private GameObject Enemy1;
	//private GameObject Enemy2;
	//private GameObject Enemy3;
	//private GameObject Enemy4;

	public GameObject[] enemies;   // 敵の種類のリスト
	public int count;

	public float apperTime;  // 敵が出現する時間の間隔
	private float currentTime;  // 前の敵が現れてからの時間を計る

	public int typeOfEnemy;

	private float maxX;
	private float minX;
	private float maxY;
	private float minY;


	void Start () {
		// 初期化
		count = 0;
		currentTime = 0.0f;
		apperTime = Random.Range(1.5f, 2f);

		maxX = -25f;
		minX = 25f;
		maxY = 4f;
		minY = 25f;

	}


	void Update () {
		currentTime += Time.deltaTime;
		if(currentTime > apperTime) {
			Appear();
		}
	}

	void Appear() {
		// 出現する敵の種類をランダムに決める
		typeOfEnemy = Random.Range(0,5);

		// 出現する敵の位置を一定範囲内でランダムに決める
		float RXPosition = Random.Range(maxX, minX);
		float RYPositon = Random.Range(maxY, minY);
		Vector3 RPosition = new Vector3(RXPosition, RYPositon, transform.position.z);

		Instantiate(enemies[typeOfEnemy], RPosition, Quaternion.identity);
    //GameObject a = Instantiate(enemies[typeOfEnemy], RPosition, Quaternion.identity) as GameObject;
		currentTime = 0.0f;
	}
}
