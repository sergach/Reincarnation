using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
	public string damage_tag;
	public int max_health;
	public int poison_count;
	private int hp;

	public GameObject[] hpCells;
	public GameObject poisonId;
	public TextMesh poisonCaption;

	void Start () 
	{
		hp = max_health;
	}
	
	public void Collide(Collision2D otherColl)
	{
		if (otherColl.gameObject.tag == damage_tag) 
		{
			hpCells[hp-1].SetActive(false);
			if (hp > 0)
				hp--;
		}
		if (damage_tag == "BadAttack" & otherColl.gameObject.tag == "SuperAttack")
		{
			for (int i=0; i<5; i++)
			{
				hpCells[hp-1].SetActive(false);
				if (hp > 0)
					hp--;
			}
		}
	}

	void Update()
	{
		if (poisonId != null) 
		{
			if (poison_count > 0)
			{
				poisonId.SetActive(true);
				poisonCaption.text = "x " + poison_count.ToString();
			}
			else
				poisonId.SetActive(false);
		}

	}

	public void PickPoison()
	{
		poison_count++;
	}

	public void DrinkPoison()
	{
		if (poison_count > 0 & hp < max_health) 
		{
			poison_count--;
			hp = max_health;
			foreach (GameObject go in hpCells)
				go.SetActive(true);
		}
	}

	public bool IsDead()
	{
		if (hp <= 0)
			return true;
		else
			return false;
	}
}
