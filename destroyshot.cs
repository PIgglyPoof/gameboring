using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyshot : MonoBehaviour {
	public scoreboard gamecontroller;

	void Start()
	{
		GameObject gamecontrollerobject = GameObject.FindGameObjectWithTag ("GameController");
		gamecontroller= gamecontrollerobject.GetComponent<scoreboard> ();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "shot") {
			Destroy (coll.gameObject);
			gamecontroller.gameoverfunc ();
			gamecontroller.restarttextfunc ();
		}
	}
}
