using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // LoadScene를 사용하기 위하여 필수!!

public class ClearDirector : MonoBehaviour {
	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene("GameScene");
		}
	}
}