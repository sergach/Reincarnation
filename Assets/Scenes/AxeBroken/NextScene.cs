﻿using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {
	public float time;
	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 3f) {
						Application.LoadLevel ("Reincarnation");
				}
	}
}
