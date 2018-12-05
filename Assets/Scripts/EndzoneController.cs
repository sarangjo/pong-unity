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

	void Start()
	{
		this.score = 0;
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.CompareTag ("Ball")) {
			collision.gameObject.GetComponent<BallController> ().Reset ();
			this.score++;
		}
	}
}
