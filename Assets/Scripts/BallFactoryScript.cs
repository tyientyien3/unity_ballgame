using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
	public GameObject ball;
    // BallFactory Script と Ball のプレハブを結びつけるための記述。
    // ball はInspector からアクセスできる変数として宣言

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(ball, transform.position, transform.rotation);
        // 第一引数＝インスタンス（プレハブの名前）。第二引数＝ballfactoryの位置。第三引数＝ballfactoryの回転
        InvokeRepeating("SpawnBall", 0f, 1f);
        // 下のメソッド渡している 。ゲーム開始の0秒後（第二引数）から1秒毎（第三引数）に実行される
    }

    void SpawnBall()
    // メソッドの実行結果をどこにも返す必要がなければvoid
    {
    	Instantiate(ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    // 第一引数＝プレハブの名前　第二引数＝位置　第三引数＝回転
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
