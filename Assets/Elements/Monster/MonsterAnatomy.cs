using UnityEngine;
using System.Collections;

public class MonsterAnatomy : MonoBehaviour 
{
	public Health health;

	void OnCollisionEnter2D(Collision2D otherColl)
	{
		health.Collide (otherColl);
	}

	void Update () 
	{
		if (health.IsDead ()) 
		{
			Destroy(gameObject);
		}
	}
}
