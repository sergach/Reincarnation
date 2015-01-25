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
