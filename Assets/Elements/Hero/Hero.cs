using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour 
{
	public LegsScript legs;
	private float time;

	public float move;
	private float health;					//здоровье
	public int poison_count;				//кол-во зелей в мешке
	public float max_health = 100f;			//max здоровье
	
	public GameObject AxePref;
	private GameObject axe;

	void Start () 
	{
		time = 0f;
		health = max_health;
		poison_count = 0;

		axe = Instantiate (AxePref, Vector3.zero, Quaternion.identity) as GameObject;
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

		if (axe != null)
		{
			axe.transform.position = transform.position;
			if (Input.GetMouseButtonDown (0)) 
			{
				axe.GetComponent<Axe>().Attack();
			}
		}

		if (go)
		{
			time -= Time.deltaTime*12;
			legs.Go ();
		} 
		else legs.Stop();
		
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
