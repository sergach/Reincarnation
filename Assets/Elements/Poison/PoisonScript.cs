using UnityEngine;
using System.Collections;

public class PoisonScript : MonoBehaviour {


	void Start () {
	}
	

	void Update () {	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Hero") {
			other.gameObject.GetComponent<Hero>().poison_count += 1;
			Destroy(gameObject);
		};

	}
}
