using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour 
{
	public GameObject leg0, leg1;
	private float time;

	public float move;
	public float health;		//здоровье
	public int poison_count;			//кол-во зелей в мешке
	public float max_health = 100f;			//max здоровье


	void Start () 
	{
		time = 0f;
		health = max_health;
		poison_count = 0;
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


		if (Input.GetKey(KeyCode.H))
		{
			if (poison_count>0 && health<100f)
			{
				health = max_health;
				poison_count -= 1;
			}
		}
	}

}
