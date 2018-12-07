using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (0, moveVertical);
		rb2d.velocity = (speed * movement);
	}
}
