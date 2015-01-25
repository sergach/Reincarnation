/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class Bam : MonoBehaviour
{
	public float k;

	public Transform bar;
	public float strength;

	void Start () 
	{
		k = 0f;
		strength = 1f;
	}

	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			k = 1;
			if (strength-0.05f>0)
				strength -= 0.05f;
			else strength = 0;
		}

		if (k > 0) 
		{
			k-=Time.deltaTime;
		}
		transform.rotation = Quaternion.Euler (0, 0, k * 45f);
		
		bar.localScale = new Vector3 (strength, 1, 1);

		if (strength <= 0) 
		{
			Application.LoadLevel("AxeBroken");
		}
	}
}
