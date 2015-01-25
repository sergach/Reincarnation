/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class ReincarnationScript : MonoBehaviour {
	public static int nextLevel;
	public static int levels = 0;

	public float speed;
	public float delay;
	private float time;

	void Start () 
	{
		time = 0f;
	}

	void Update () 
	{
		transform.Rotate (0, 0, Time.deltaTime * speed);

		time += Time.deltaTime;
		if (time > delay) 
		{
			levels++;
			Application.LoadLevel(levels % 4);

		}
	}
}
