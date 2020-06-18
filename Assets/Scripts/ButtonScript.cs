using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// シーンを呼び出すための記述

public class ButtonScript : MonoBehaviour
{
	public void ReplayGame()
	// Inspectorから呼び出すので publicにする
	{
		SceneManager.LoadScene("MainScene");
		// mainシーンに戻るためのメソッド
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
