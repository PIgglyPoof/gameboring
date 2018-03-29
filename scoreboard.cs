using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class scoreboard : MonoBehaviour {
	showspawnner increaseobsfreqency;
	AudioSource obstacleshotaudio;
	int count;
	int adcheck,adluck,flag=0;
	public Text scorebrd;
	public Text gameovertext;
	public Text restarttext;
	private bool restart;
	void Start(){
		increaseobsfreqency = GetComponent<showspawnner> ();
		obstacleshotaudio = GetComponent<AudioSource> ();
		count = -1;
		restart = false;
		adluck = Random.Range (0, 16);
		scorechange ();
	}

	void Update()
	{
		if (restart == true) {
			if (adcheck != 1) {
				if (adluck == 4) {
					adcheck = 1;
					Advertisement.Show ();
				}
			}

	
			if (Input.GetButton ("Fire1") && !Advertisement.isShowing) {
				StartCoroutine (loadingscene ());
			}
		} else if (flag == 0 && count > 20) {
			increaseobsfreqency.nextobstacle = 1f;
			flag = 1;
		} else if (count > 50){
			restarttextfunc ();
		gameovertext.text = "THANKS YOU !! YOU RANDOM GUY > IT WAS MY FIRST GAME . I KNOW IT WAS PRETTY DULL AND SIMPLE YOU MIGHT BE THE ONLY ONE TO REACH THIS FAR";
			}
		}

	IEnumerator loadingscene()
	{
		yield return new WaitForSeconds (0.2f);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}


	public void scorechange()
	{
		count += 1;
		scorebrd.text = "Score: " + count;
	}

	public void gameoverfunc()
	{	if(count<=50)
		gameovertext.text = "GAMEOVER";
	}

	public void restarttextfunc()
	{
		restarttext.text = "TAP TO RESTART";
		restart = true;
		GetComponent<showspawnner> ().enabled = false;
	}

	public void obstacleshotfunc()
	{
		obstacleshotaudio.Play ();
	}
}
