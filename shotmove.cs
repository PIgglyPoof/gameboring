using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotmove : MonoBehaviour {
	public float speed;
	Rigidbody2D shot;
	Vector2 pos;
	void Start()
	{
		shot = GetComponent<Rigidbody2D> ();
		shot.velocity = transform.right * speed;
	}

}
