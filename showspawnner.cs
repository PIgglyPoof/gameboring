using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showspawnner : MonoBehaviour {

	public float starttime, nextobstacle;
	public Transform[] spawnpos;
	public GameObject[] obstacle;
	int obs,spawn;
	void Update () {
		if (Time.time > starttime) {
			starttime = Time.time + nextobstacle;
			spawn = Random.Range (0, spawnpos.Length);
			obs = Random.Range (0, obstacle.Length);
			Instantiate (obstacle [obs], spawnpos [spawn].position, Quaternion.identity);
		}
	}
}
