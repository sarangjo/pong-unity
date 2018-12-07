using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndzoneController : MonoBehaviour
{
	public int _score;
	public int score {
		get {
			return this._score;
		}
		set {
			this._score = value;
			if (this.text != null) {
				this.text.text = this.playerName + ": " + value;
			}
		}
	}
	public Text text;
	public string playerName;

	private Vector2 origin;

	void Start()
	{
		this.score = 0;
		this.origin = new Vector2 (transform.position.x, 100);
	}

	void FixedUpdate()
	{
		RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.down, Mathf.Infinity, 1 << 8);

		if (hit.collider != null) {
			if (hit.collider.name.Equals("Ball")) {
				hit.collider.GetComponent<BallController> ().Reset ();
				this.score++;
			}
		}
	}
}
