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
