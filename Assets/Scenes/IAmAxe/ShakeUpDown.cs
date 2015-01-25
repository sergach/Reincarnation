/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class ShakeUpDown : MonoBehaviour {
	
	private float time;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		time = 0;
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		transform.position = pos + Vector3.up * 0.5f * Mathf.Sin (time*2f);
	}
}
