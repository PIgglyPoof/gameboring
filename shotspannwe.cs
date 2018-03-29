using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotspannwe : MonoBehaviour {
	public float shottime;
	public float nextfire;
	public GameObject shot;
	public Transform spawnposition;
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > shottime) {
			shottime = Time.time + nextfire;
			Instantiate (shot, spawnposition.position, Quaternion.identity);
		}
	}
}
