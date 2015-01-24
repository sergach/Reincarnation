using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour 
{
	private Camera camera;
	public static Vector2 mousePos;

	public GameObject HeroPref;
	public GameObject BossPref;
	public GameObject MonsterPref;
	public GameObject SheepPref;
	
	public Transform heroSpawn;
	public Transform bossSpawn;
	public Transform[] monsterSpawn;
	public Transform[] sheepSpawn;

	void Start () 
	{
		camera = GameObject.Find("Main Camera").GetComponent<Camera>();
		/*Instantiate (HeroPref, heroSpawn.position, Quaternion.identity);
		Instantiate (BossPref, bossSpawn.position, Quaternion.identity);
		foreach (Transform t in monsterSpawn)
			Instantiate (MonsterPref, t.position, Quaternion.identity);
		foreach (Transform t in sheepSpawn)
			Instantiate (SheepPref, t.position, Quaternion.identity);*/
	}

	void Update () 
	{
		mousePos = camera.ScreenToWorldPoint (Input.mousePosition);
	}
}
