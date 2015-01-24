using UnityEngine;
using System.Collections;

public class AxeStrike : MonoBehaviour 
{

	public float strength;
	public Transform progressbar;
	public GameObject axe;

	void Start () 
	{
		strength = 1;
	}

	void Update () 
	{
		progressbar.localScale = new Vector3(strength,1,1);

	}
}
