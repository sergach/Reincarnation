﻿/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {

	public AudioClip FonSong;

	void Update () {

		if (audio.isPlaying == false) 
		{
			audio.clip = FonSong;
			audio.Play ();
		}
	
	}
}
