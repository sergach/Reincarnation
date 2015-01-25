/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour 
{
	private SpriteRenderer sr;

	public GameObject attack;
	public Sprite goldenSprite;

	private Vector2 direction;

	public float offset;
	public float swingDeg;
	private float swing;
	private float angle;

	public string attack_tag;

	public AudioClip axeAudio;
	


	void Start () 
	{
		sr = GetComponent<SpriteRenderer> ();
		swing = 1f;
	}

	public void SetDirection(Vector2 d)
	{
		direction = d;
	}

	void Update () 
	{
		direction.Normalize();
		angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle + swingDeg * swing);

		if (transform.up.x > 0)
			transform.localScale = new Vector3(1,1,1);
		else
			transform.localScale = new Vector3(-1,1,1);

		if (transform.up.y > 0) 
			sr.sortingOrder = -3;
		else 
			sr.sortingOrder = 3;
	}

	public void Attack()
	{
		AudioSource.PlayClipAtPoint(axeAudio, transform.position);

		swing = -swing;
		GameObject a = Instantiate(attack,transform.position,Quaternion.Euler(0f, 0f, angle)) as GameObject;
		a.transform.localScale = new Vector3(-swing,1,1);
		a.tag = attack_tag;
	}

	public void Upgrade()
	{
		attack_tag = "SuperAttack";
		sr.sprite = goldenSprite;
	}
}
