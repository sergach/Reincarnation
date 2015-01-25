/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class GoldenAxeItem : MonoBehaviour 
{
	public static bool spawn = false;
	public static Vector2 pos;
	public static Quaternion rot;

	void OnTriggerEnter2D(Collider2D otherColl)
	{
		Debug.Log ("OnTriggerEnter2D");
		PlayableSheepScript sheep = otherColl.gameObject.GetComponent<PlayableSheepScript>();
		Hero hero = otherColl.gameObject.GetComponent<Hero>();
		if (sheep != null) {
			GoldenAxeItem.pos = transform.position;
			GoldenAxeItem.rot = transform.rotation;
			GoldenAxeItem.spawn = true;
			sheep.Die ();
		}
		if (hero != null) 
		{

			hero.GetGoldenAxe ();
			Destroy (gameObject);
		}
	}
}
