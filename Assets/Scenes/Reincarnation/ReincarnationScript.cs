using UnityEngine;
using System.Collections;

public class ReincarnationScript : MonoBehaviour 
{
	public static int nextLevel;

	public float speed;
	public float delay;
	private float time;

	void Start () 
	{
		time = 0f;
	}

	void Update () 
	{
		transform.Rotate (0, 0, Time.deltaTime * speed);

		time += Time.deltaTime;
		if (time > delay) 
		{
			Application.LoadLevel(nextLevel);

		}
	}
}
