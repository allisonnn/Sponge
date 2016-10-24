﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 2f;

	private Rigidbody2D rb2d;
	private int count = 0;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveH, moveV);
		rb2d.AddForce (movement * speed);
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.CompareTag ("sponge_piece")) {
			other.collider.isTrigger = true;
			Debug.Log("iwiwiwiw");
			count++;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("sponge_piece")) {
			other.gameObject.SetActive (false);
			count = 0;
		}
	}
}
