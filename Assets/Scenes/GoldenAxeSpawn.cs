using UnityEngine;
using System.Collections;

public class GoldenAxeSpawn : MonoBehaviour {

	public GameObject goldenAxeItem;

	void Start () 
	{
		if (GoldenAxeItem.spawn)
			Instantiate(goldenAxeItem, GoldenAxeItem.pos, GoldenAxeItem.rot);
	}

	void Update () 
	{
	
	}
}
