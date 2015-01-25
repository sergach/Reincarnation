/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class PoisonScript : MonoBehaviour {


	void Start () {
	}
	

	void Update () {	
	}

	void OnTriggerEnter2D(Collider2D other){
		Hero h = other.gameObject.GetComponent<Hero> ();
		if (h != null) {
			h.health.PickPoison();
			Destroy(gameObject);
		};

	}
}
