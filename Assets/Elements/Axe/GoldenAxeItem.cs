using UnityEngine;
using System.Collections;

public class GoldenAxeItem : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D otherColl)
	{
		PlayableSheepScript sheep = otherColl.gameObject.GetComponent<PlayableSheepScript>();
		Hero hero = otherColl.gameObject.GetComponent<Hero>();
		if (sheep!=null) sheep.Die();
		if (hero != null) 
		{
			hero.GetGoldenAxe ();
			Destroy (gameObject);
		}
	}
}
