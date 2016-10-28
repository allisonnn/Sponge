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
		Rigidbody2D rb2d;
		if (other.gameObject.CompareTag ("Player")) {
			rb2d = other.gameObject.GetComponent <Rigidbody2D> ();
			rb2d.AddForce (new Vector2 (25, 0));
//			rb2d.transform (rb2d.position + movement);
			count++;
		}
		if (count == 3) {
			this.gameObject.SetActive(false);
			count = 0;
		}
	}

}
