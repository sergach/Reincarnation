using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour 
{
	private SpriteRenderer sr;
	
	public Camera camera;
	public GameObject attack;

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
		Vector3 direction = camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		direction.z = 0f; direction.Normalize();
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
