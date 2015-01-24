using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour 
{
	private SpriteRenderer sr;

	public GameObject attack;

	private Vector2 direction;

	public float offset;
	public float swingDeg;
	private float swing;
	private float angle;

	public string attack_tag;

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
		swing = -swing;
		GameObject a = Instantiate(attack,transform.position,Quaternion.Euler(0f, 0f, angle)) as GameObject;
		a.transform.localScale = new Vector3(-swing,1,1);
		a.tag = attack_tag;
	}
}
