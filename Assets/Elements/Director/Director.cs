using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour 
{
	private new Camera camera;
	public static Vector2 mousePos;
	void Start () 
	{
		camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

	void Update () 
	{
		mousePos = camera.ScreenToWorldPoint (Input.mousePosition);
	}
}
