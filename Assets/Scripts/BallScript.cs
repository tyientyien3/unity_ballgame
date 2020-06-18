using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// シーンを読み込むための記述

public class BallScript : MonoBehaviour
{
	private float speed;
    // ボールスピードの変数宣言

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f, 15f);
        // 5から15までの速さでランダムにボールが動く

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        // -1 はz座標を下向きに動くようにしたいから p15
        // Time.deltaTime で端末ごとの速度を調整 p15
        
        // ココ以下はp21
        if (transform.position.z < -13.0f)
        // ゲームオーバーになる処理。もしz座標が-13より小さくなったら
        {
            // Debug.Log("Game Over");
            // コンソールに文字が表示される
            // Time.timeScale = 0;
            // ゲーム自体を止める処理。時間を止める

            SceneManager.LoadScene("GameOverScene");
            // 呼び出したいシーンの名前 p24 + 一番上でusing UnityEngine.SceneManagement;の記述が必要
        }
    }

    private void OnCollisionEnter(Collision collision)
    // ball が何かに当たったときにというメソッド
    {
        if (collision.gameObject.CompareTag("Paddle"))
        // 　このタグは　paddleのInspectorのタグ（左上の方）で定義している P19
        // collision=衝突　gameObject=このスクリプトのオブジェクト（=ball） タグ=Paddle
        {
            Destroy(gameObject);
            // Paddleにあたったら消える

            // ここからp20
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            // localScaleは書かなきゃいけない物という認識。　次第に小さくなるので-=(大きくするなら+=)。x座標が0.2-1.0の大きさでランダムで小さくなる。
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                // もしx座標が１よりも小さくなったらx座標は1.0fになる。
            }
        }

    }
}
