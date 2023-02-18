using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour
{
	private Rigidbody2D rigidBody;

	private float moveSpeed = 2.5f;
	private float jumpSpeed = 10f;

	private bool isGrounded = false;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (InputController.left) {
			rigidBody.AddForce(new Vector2(-moveSpeed, 0));
		}
		if (InputController.right) {
			rigidBody.AddForce(new Vector2(moveSpeed, 0));
		}
		if (InputController.jump && isGrounded) {
			rigidBody.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.transform.tag == "Ground") {
			isGrounded = true;
		}
	}
	void OnTriggerExit2D(Collider2D other) {
		if (other.transform.tag == "Ground") {
			isGrounded = false;
		}
	}
}
