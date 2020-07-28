/////////////////////////////////////
///LESSON4 課題 配列を宣言して出力しましょう
/////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {1, 2, 3, 4, 5};

		// 配列の各要素の値を順番に表示
		for (int i = 0; i < points.Length; i++) {
			Debug.Log (points [i]);
		}
		// 配列の各要素の値を逆順に表示
		for (int i = points.Length-1; i >= 0; i--) {
			Debug.Log (points [i]);
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
