/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class SheepScript : MonoBehaviour {

	public LegsScript legs;

	private float time;

	public float move;

	public float deadHeight;

	private float deathTime = 0.5f;
	private bool dead = false;

	public AudioClip dieAudio;

	void Start () {
		time = 0f;	
	}
	

	void Update () {
		if (dead) {
			if (time < deathTime) {
				time += Time.deltaTime;
				transform.rotation = new Quaternion(0f, 0f, time / deathTime * 3.14f, 0f);
			}
		}
	}

	public void Die()
	{
		AudioSource.PlayClipAtPoint(dieAudio, transform.position);

		deadHeight = transform.position.y - 2f;
		dead = true;
		time = 0f;
		legs.Stop ();
		//rigidbody2D.
	}
}
