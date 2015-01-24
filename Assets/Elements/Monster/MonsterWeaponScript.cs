using UnityEngine;
using System.Collections;

public class MonsterWeaponScript : MonoBehaviour 
{
	public GameObject AxePref;
	private GameObject axe;

	public float fightDelay;
	private float time;

	public HeroDetectorScript heroDetector;

	void Start () 
	{
		axe = Instantiate (AxePref, Vector3.zero, Quaternion.identity) as GameObject;
		axe.GetComponent<Axe>().attack_tag = "BadAttack";
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
