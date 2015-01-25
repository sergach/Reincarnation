using UnityEngine;
using System.Collections;

public class PoisonEyeScript : MonoBehaviour {

	private float time;
	public float delay;
	public float delta;
	private float centerX;

	void Start () {
		time = 0f;
		centerX = transform.position.x - 0.5f;
	}
	
	void Update () {
		time -= Time.deltaTime;

		if (time < 0) 
		{
			delta = delta*(-1f);
			transform.localPosition = new Vector3(centerX + delta,transform.localPosition.y,transform.localPosition.z);
			time = Random.Range(0,delay);
		}

	
	}
}
