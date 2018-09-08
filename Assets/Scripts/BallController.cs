using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public float normalSpeed = 5f;
	public float fastSpeed = 10f;

	private float speed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
	{
		this.rb2d = GetComponent<Rigidbody2D> ();
		this.speed = normalSpeed;
		this.Reset ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("f")) {
			this.speed = fastSpeed;
		} else if (Input.GetKeyUp ("f")) {
			this.speed = normalSpeed;
		} else if (Input.GetKeyUp ("r")) {
			this.Reset ();
		}
			
		// Always have constant speed
		rb2d.velocity = rb2d.velocity * (speed / rb2d.velocity.magnitude);
	}

	void Reset ()
	{
		rb2d.MovePosition (new Vector2 (0, 0));
		float angle = (Random.value * 0.6f * Mathf.PI) - (0.3f * Mathf.PI);

		rb2d.velocity = new Vector2 (speed * Mathf.Cos (angle), speed * Mathf.Sin (angle));
	}
}
