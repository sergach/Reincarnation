using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour 
{
	public GameObject leg0, leg1;
	private float time;

	public float move;

	void Start () 
	{
		time = 0f;
	}

	void Update () 
	{
		bool go = false;
		if (Input.GetKey (KeyCode.W)) 
		{
			rigidbody2D.AddForce (move * new Vector2 (0, 1) * Time.deltaTime);
			go = true;
		}
		if (Input.GetKey (KeyCode.A))
		{
			rigidbody2D.AddForce (move * new Vector2(-1,0) * Time.deltaTime);
			go = true;
		}
		if (Input.GetKey (KeyCode.S))
		{
			rigidbody2D.AddForce (move * new Vector2(0,-1) * Time.deltaTime);
			go = true;
		}
		if (Input.GetKey (KeyCode.D))
		{
			rigidbody2D.AddForce (move * new Vector2(1,0) * Time.deltaTime);
			go = true;
		}

		if (go)
		time -= Time.deltaTime*12;
		
		leg0.transform.localPosition = new Vector3(-0.17f,0.05f*Mathf.Sin (time),0);
		leg1.transform.localPosition = new Vector3(0.17f,0.05f*Mathf.Sin (time+3.14f),0);
	}
}
