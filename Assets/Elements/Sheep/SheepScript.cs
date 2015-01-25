using UnityEngine;
using System.Collections;

public class SheepScript : MonoBehaviour {

	public LegsScript legs;

	private float time;

	public float move;

	public float deadHeight;

	private float deathTime = 0.5f;
	private bool dead = false;

	void Start () {
		time = 0f;	
	}
	

	void Update () {
		if (dead) {
			if (time < deathTime) {
				time += Time.deltaTime;
				transform.rotation = new Quaternion(0f, 0f, time / deathTime * 3.14f, 0f);
			}
		}
	}

	public void Die()
	{
		deadHeight = transform.position.y - 2f;
		dead = true;
		time = 0f;
		legs.Stop ();
		//rigidbody2D.
	}
}
