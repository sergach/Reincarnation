using UnityEngine;
using System.Collections;

public class GoldenAxeItem : MonoBehaviour 
{
	public static bool spawn = false;
	public static Vector2 pos;
	public static Quaternion rot;

	void OnTriggerEnter2D(Collider2D otherColl)
	{
		Debug.Log ("OnTriggerEnter2D");
		PlayableSheepScript sheep = otherColl.gameObject.GetComponent<PlayableSheepScript>();
		Hero hero = otherColl.gameObject.GetComponent<Hero>();
		if (sheep != null) {
			GoldenAxeItem.pos = transform.position;
			GoldenAxeItem.rot = transform.rotation;
			GoldenAxeItem.spawn = true;
			sheep.Die ();
		}
		if (hero != null) 
		{

			hero.GetGoldenAxe ();
			Destroy (gameObject);
		}
	}
}
