using UnityEngine;
using System.Collections;

public class IAmPoisonScript : MonoBehaviour {

	public float time;


	void Start () {
	}
	

	void Update () {

		time -= Time.deltaTime;
		
		if (time < 0) 
		{
			Application.LoadLevel("Reincarnation");
		}
	
	}
}
