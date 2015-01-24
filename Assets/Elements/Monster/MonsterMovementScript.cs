using UnityEngine;
using System.Collections;

public class MonsterMovementScript : MonoBehaviour {
	public HeroDetectorScript heroDetector;
	public RandomMovementScript randomMovement;
	public LegsScript legs;

	[Range( 100f, 2000f )]
	public float force = 1500f;
	// Use this for initialization
	private bool randomMove = true;
	private GameObject hero;
	void Start () {
		randomMove = true;
		randomMovement.StartRandomMovement ();
	}
	
	// Update is called once per frame
	void Update () {
		if (heroDetector.IsDetecting () && randomMove) {
			randomMovement.StopRandomMovement ();
			legs.Go ();
			hero = heroDetector.GetHero ();
			randomMove = false;
		} else if (!heroDetector.IsDetecting () && !randomMove) {
			randomMove = true;
			legs.Stop();
			randomMovement.StartRandomMovement();
		}
		if (!randomMove) {
			MoveToHero();
		}
	}

	private void MoveToHero(){
		Vector2 forceV2 = new Vector2 (hero.transform.position.x - transform.position.x,
		                             hero.transform.position.y - transform.position.y);
		forceV2.Normalize ();
		forceV2 *= force;
		rigidbody2D.AddForce (forceV2 * Time.deltaTime);
	}


}
