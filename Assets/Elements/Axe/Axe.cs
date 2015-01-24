using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour 
{
	private SpriteRenderer sr;

	public GameObject attack;
	
	public float offset;
	public float swingDeg;
	private float swing;
	private float angle;

	void Start () 
	{
		sr = GetComponent<SpriteRenderer> ();
		swing = 1f;
	}

	void Update () 
	{
		Vector2 direction = Director.mousePos - new Vector2(transform.position.x,transform.position.y);
		direction.Normalize();
		angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle + swingDeg * swing);


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
	}
}
