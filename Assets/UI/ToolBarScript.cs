﻿using UnityEngine;
using System.Collections;

public class ToolBarScript : MonoBehaviour {
	private float time = 0f;
	public float maxTime = 7f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > maxTime) {
			gameObject.SetActive(false);
		}
	}
}
