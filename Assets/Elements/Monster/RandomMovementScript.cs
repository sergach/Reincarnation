using UnityEngine;
using System.Collections;

public class RandomMovementScript : MonoBehaviour {
	private const float minForce = 10f;

	public LegsScript legsScript;

	[Range( 1f, 10f )]
	public float movementTimePeriod = 1f;

	[Range( 10f, 1000f )]
	public float movementForce = 10f;

	[Range( 0.1f, 1f )]
	public float legMovementTime = 0.1f;

	private float movementTime = 0;
	private bool go = true;
	
	private float legTime = 0;
	private bool legGo = false;
	private float randomMovementTimePeriod;
	// Use this for initialization
	void Start () {
		//StartRandomMovement ();
		randomMovementTimePeriod = Random.Range(movementTimePeriod / 2, movementTimePeriod);
	}

	public void StartRandomMovement() {
		go = true;
		movementTime = 0f;
	}

	public void StopRandomMovement() {
		legsScript.Stop ();
		go = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (go) {
			movementTime += Time.deltaTime;
			if (movementTime > randomMovementTimePeriod) {
				randomMovementTimePeriod = Random.Range(movementTimePeriod / 2, movementTimePeriod);
				movementTime = 0;
				legGo = true;
				legTime = 0;
				legsScript.Go();
				Push();
			}

			if (legGo) {
				legTime += Time.deltaTime;
				if (legTime > legMovementTime) {
					legGo = false;
					legsScript.Stop ();
				}
			}
		}
	}

	private void Push() {
		Vector2 force = new Vector2 (Random.Range (-movementForce, movementForce),
		                             Random.Range (-movementForce, movementForce));
		rigidbody2D.AddForce (force);
	}
}
