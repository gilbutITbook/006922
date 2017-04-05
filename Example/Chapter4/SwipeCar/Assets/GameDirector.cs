using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // UI 부품을 사용하기 위해서 중요!！

public class GameDirector : MonoBehaviour {

	GameObject car;
	GameObject flag;
	GameObject distance;

	void Start() {
		this.car = GameObject.Find("car");
		this.flag = GameObject.Find("flag");
		this.distance = GameObject.Find("Distance");
	}

	void Update() {
		float length = this.flag.transform.position.x - this.car.transform.position.x;
		this.distance.GetComponent<Text>().text = "골까지" + length.ToString("F2") + "m";
	}
}