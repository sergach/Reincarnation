/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
using UnityEngine;
using System.Collections;

public class MonsterWeaponScript : MonoBehaviour 
{
	public GameObject AxePref;
	private GameObject axe;
	public Sprite monsterAxeSprite;

	public float fightDelay;
	private float time;

	public HeroDetectorScript heroDetector;

	void Start () 
	{
		axe = Instantiate (AxePref, Vector3.zero, Quaternion.identity) as GameObject;
		axe.GetComponent<Axe>().attack_tag = "BadAttack";
		axe.GetComponent<SpriteRenderer> ().sprite = monsterAxeSprite;
	}

	void Update () 
	{
		if (axe != null)
		{
			axe.transform.position = transform.position;

			if (heroDetector.IsDetecting())
			{
				Vector2 heroPosition = new Vector2(heroDetector.GetHero().transform.position.x,
				                                   heroDetector.GetHero().transform.position.y);
				axe.GetComponent<Axe>().SetDirection(heroPosition - new Vector2(transform.position.x,transform.position.y));
				time -= Time.deltaTime;
				if (time<0) 
				{
					axe.GetComponent<Axe>().Attack();
					time = fightDelay;
				}
			}
		}
	}
}
