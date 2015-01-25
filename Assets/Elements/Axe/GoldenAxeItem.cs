using UnityEngine;
using System.Collections;

public class GoldenAxeItem : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D otherColl)
	{
		Debug.Log ("OnTriggerEnter2D");
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
