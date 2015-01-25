using UnityEngine;
using System.Collections;

public class Electric : MonoBehaviour 
{
	private SpriteRenderer sr;
	private Color color;
	public float delay;
	private float time;

	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		color = sr.color;
		time = 0f;
	}

	void Update () {
		time -= Time.deltaTime;
		if (time < 0) 
		{
			if (Random.Range(0,2)==0)
				sr.color = Color.yellow;
			else
				sr.color = Color.white;
			transform.localScale = new Vector3(Random.Range(0f,2f),Random.Range(0f,2f),1f);
			transform.Rotate(0,0,Random.Range(0f,3.14f));
			time = Random.Range(0,delay);
		}
	}
}
