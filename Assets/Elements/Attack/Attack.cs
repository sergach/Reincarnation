/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
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
