using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class destroybycontact : MonoBehaviour {
	public scoreboard score;
	void Start()
	{	 
		GameObject gamecontrollerobject = GameObject.FindGameObjectWithTag ("GameController");
		if (gamecontrollerobject != null) {
			score = gamecontrollerobject.GetComponent<scoreboard> ();
		}
		if (score == null) {
			Debug.Log ("Cannot Find Script");
		}
	}

		void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "shot") {
			Destroy (gameObject);
			Destroy (coll.gameObject);
			score.obstacleshotfunc ();
			score.scorechange ();
		}
	
}
}
