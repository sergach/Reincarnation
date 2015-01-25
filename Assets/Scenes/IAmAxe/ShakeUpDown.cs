using UnityEngine;
using System.Collections;

public class ShakeUpDown : MonoBehaviour {
	
	private float time;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		time = 0;
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		transform.position = pos + Vector3.up * 0.5f * Mathf.Sin (time*2f);
	}
}
