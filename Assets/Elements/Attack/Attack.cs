using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour 
{
	public float speed;
	public float force;
	private float time;
	private SpriteRenderer sr;
	private Color color;
	private float scaleSign;

	void Start ()
	{
		time = 0f;
		sr = GetComponent<SpriteRenderer> ();
		color = sr.color;
		rigidbody2D.AddForce (force* transform.up);
		scaleSign = Mathf.Sign (transform.localScale.x);
	}


	void Update () 
	{
		time += Time.deltaTime * speed;
		sr.color = new Color (color.r, color.g, color.b, 1 - time);
		transform.localScale = new Vector3 (scaleSign*(1 + time/3), 1 + time/3, 1f);
		if (time > 1)
			Destroy (gameObject);
	}
}
