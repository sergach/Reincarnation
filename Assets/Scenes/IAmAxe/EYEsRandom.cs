/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class EYEsRandom : MonoBehaviour {
	
	private float time;
	public float delay;

	void Start () {
		time = 0f;
	}
	
	void Update () {
		time -= Time.deltaTime;

		if (time < 0) 
		{
			transform.localPosition = new Vector3(-transform.localPosition.x,transform.localPosition.y,transform.localPosition.z);
			time = Random.Range(0,delay);
		}
	}
}
