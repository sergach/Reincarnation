using UnityEngine;
using System.Collections;

public class EYEsRandom : MonoBehaviour {
	
	private float time;
	public float delay;

	// Use this for initialization
	void Start () {
		time = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time < 0) 
		{
			transform.localPosition = new Vector3(-transform.localPosition.x,transform.localPosition.y,transform.localPosition.z);
			time = Random.Range(0,delay);
		}
	}
}
