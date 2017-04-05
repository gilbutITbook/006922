using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	void Start() {
	}

	void Update() {
		// 左矢印が押された時
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			transform.Translate(-3, 0, 0);  // 左に「3」動かす
		}

		// 右矢印が押された時
		if(Input.GetKeyDown(KeyCode.RightArrow)) {
			transform.Translate(3, 0, 0);  // 右に「3」動かす
		}
	}
}