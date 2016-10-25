using UnityEngine;
using System.Collections;

public class spongeController : MonoBehaviour {
	private int count;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			Debug.Log("iwiwiwiw");
			count++;
		}
		if (count == 3) {
//			other.collider.isTrigger = true;
			this.gameObject.SetActive(false);
			count = 0;
		}
	}
//
//	void OnTriggerEnter2D(Collider2D other) {
//		if (other.gameObject.CompareTag ("sponge_piece")) {
//			other.gameObject.SetActive (false);
//		}
//	}
}
