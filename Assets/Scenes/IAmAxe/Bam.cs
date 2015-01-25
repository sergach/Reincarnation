using UnityEngine;
using System.Collections;

public class Bam : MonoBehaviour
{
	public float k;
	public float delay;
	private float time;

	void Start () 
	{
		k = 0f;
		time = delay;
	}

	void Update () 
	{
		time += Time.deltaTime*3;
		if (Input.GetMouseButton (0) | time > delay) 
		{
			k = 1;
			time = 0;
		}

		if (k > 0) 
		{
			k-=Time.deltaTime;
		}
		transform.rotation = Quaternion.Euler (0, 0, k * 45f);
	}
}
