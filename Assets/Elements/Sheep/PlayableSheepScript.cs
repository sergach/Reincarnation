using UnityEngine;
using System.Collections;

public class PlayableSheepScript : MonoBehaviour {

	public LegsScript legs;

	private float time;

	public float move = 1000;

	[Range( 1f, 60f )]
	public float timeBeforeAxe = 10;
	private float axeTime = 0;
	private float axeFlyTime = 30;

	public GameObject axePref;
	private GameObject axe = null;

	private float deathTime = 0.5f;
	private bool dead = false;

	public AudioClip dieAudio;

	void Start () {
		time = 0f;	
	}
	

	void Update () {
		if (!dead) {
			bool go = false;

			if (Input.GetKey (KeyCode.W)) {
					rigidbody2D.AddForce (move * new Vector2 (0, 1) * Time.deltaTime);
					go = true;
			}
			if (Input.GetKey (KeyCode.A)) {
					rigidbody2D.AddForce (move * new Vector2 (-1, 0) * Time.deltaTime);
					go = true;
			}
			if (Input.GetKey (KeyCode.S)) {
					rigidbody2D.AddForce (move * new Vector2 (0, -1) * Time.deltaTime);
					go = true;
			}
			if (Input.GetKey (KeyCode.D)) {
					rigidbody2D.AddForce (move * new Vector2 (1, 0) * Time.deltaTime);
					go = true;
			}

			if (go) {
					time -= Time.deltaTime * 12;		
					legs.Go ();
			} else
					legs.Stop ();
			axeTime += Time.deltaTime;
			if (axeTime > timeBeforeAxe) {
				if (axe == null) {
					axe = Instantiate (axePref, transform.position + Vector3.up * 10f, Quaternion.identity) as GameObject;
				} else {
					if (axeTime - timeBeforeAxe < axeFlyTime) {
						Vector3 newPos = axe.transform.position + 
							(axeTime - timeBeforeAxe) / axeFlyTime * (transform.position - axe.transform.position) * 5f;

						axe.transform.Rotate(new Vector3 (
							0f,0f, (axeTime - timeBeforeAxe) * 10f
							));
						axe.transform.position = newPos;
					}
				}

			}
		} else {
			if (time < deathTime) {
				time += Time.deltaTime;
				transform.rotation = new Quaternion(0f, 0f, time / deathTime * 3.14f, 0f);
			}
		}
	}

	public void Die()
	{
		AudioSource.PlayClipAtPoint(dieAudio, transform.position);
		dead = true;
		time = 0f;
		legs.Go ();
		//rigidbody2D.
	}
}
