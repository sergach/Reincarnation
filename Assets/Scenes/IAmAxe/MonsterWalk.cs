using UnityEngine;
using System.Collections;

public class MonsterWalk : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x<0)
			transform.Translate (Vector3.right*speed*Time.deltaTime);
	}
}
