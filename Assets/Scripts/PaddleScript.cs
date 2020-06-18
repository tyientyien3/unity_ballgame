using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
	// private float speed;
	public float speed;
    // 変数の宣言
    // public にすると Paddle/Inspector/Paddle Scriptから直接speedの変更ができるようになる

    // Start is called before the first frame update
    void Start()
    {
        // speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        // Paddleの位置を取得する。x座標のみ動かしたいのでy,zは０でOK
        // Vector3()　には浮動小数点数を渡す決まりになっているのでf(float)を付ける
        //  Input.GetAxis("Horizontal")　をx座標に置く。右の矢印キーを押せば 1 、左の矢印キーを押せば -1 が返ってくると言う意味
        // Time.deltaTime == 遅いマシンでは大きな値、早いマシンでは小さな値をかけてくれるので、結果としてどのマシンでも同じ速度になる


        // Debug.Log(transform.position.x);
    }
}
