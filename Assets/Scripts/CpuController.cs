using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuController : MonoBehaviour
{
	public float speed;
	public Rigidbody2D ball;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float newVelocity;
		if (rb2d.position.y - ball.position.y < 0) {
			newVelocity = speed;
		} else if (rb2d.position.y - ball.position.y > 0) {
			newVelocity = -speed;
		} else {
			newVelocity = 0;
		}
		rb2d.velocity = new Vector2 (0, newVelocity);
	}
}
