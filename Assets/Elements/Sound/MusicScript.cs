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
