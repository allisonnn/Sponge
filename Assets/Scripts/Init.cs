using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {

	public GameObject SpongePrefabs;

	private Vector3 pos;
	private Vector3 rotation;

	void Start() {
		pos.Set (Random.value*50, Random.value*50, 0);
		rotation.Set (Random.value*360, Random.value*360, 0);
//		GameObject instance = Instantiate (SpongePrefabs, pos, rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
