/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour 
{
	public GameObject body;
	public LegsScript legs;
	private float time;

	public float move;
	public Health health;
	
	public GameObject AxePref;
	private GameObject axe;

	void Start () 
	{
		time = 0f;

		axe = Instantiate (AxePref, Vector3.zero, Quaternion.identity) as GameObject;
		axe.GetComponent<Axe>().attack_tag = "GoodAttack";
	}

	void OnCollisionEnter2D(Collision2D otherColl)
	{
		health.Collide (otherColl);
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
			body.transform.localScale = new Vector3(-1,1,1);
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
			body.transform.localScale = new Vector3(1,1,1);
		}

		if (axe != null)
		{
			axe.transform.position = transform.position;
			axe.GetComponent<Axe>().SetDirection(Director.mousePos - new Vector2(transform.position.x,transform.position.y));
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
		
		if (Input.GetMouseButtonDown (1)) 
		{
			health.DrinkPoison();
		}

		if (health.IsDead ()) 
		{
			ReincarnationScript.nextLevel = Application.loadedLevel;
			Application.LoadLevel("Reincarnation");
		}
	}

	public void GetGoldenAxe()
	{
		axe.GetComponent<Axe> ().Upgrade ();
	}
}
