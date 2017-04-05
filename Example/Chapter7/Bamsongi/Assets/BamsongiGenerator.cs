using UnityEngine;
using System.Collections;

public class BamsongiGenerator : MonoBehaviour {

	public GameObject bamsongiPrefab;

	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			GameObject bamsongi = Instantiate(bamsongiPrefab) as GameObject;

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 worldDir = ray.direction;
			bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000);
		}
	}
}