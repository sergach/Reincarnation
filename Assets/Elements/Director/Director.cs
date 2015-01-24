using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour 
{
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
		Instantiate (HeroPref, heroSpawn.position, Quaternion.identity);
		Instantiate (BossPref, bossSpawn.position, Quaternion.identity);
		foreach (Transform t in monsterSpawn)
			Instantiate (MonsterPref, t.position, Quaternion.identity);
		foreach (Transform t in sheepSpawn)
			Instantiate (SheepPref, t.position, Quaternion.identity);
	}

	void Update () 
	{
	
	}
}
