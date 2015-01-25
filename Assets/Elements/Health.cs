/*
 * This work created by Cucumber Studios is licensed under the 
 * Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/ or 
 * send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
 * */
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
			if (hp>0)
				hpCells[hp-1].SetActive(false);
			if (hp > 0)
				hp--;
		}
		if (otherColl.gameObject.tag == "SuperAttack") 
		{
			if (damage_tag == "SuperAttack") 
			{
				for (int i=0; i<50; i++) {
					if (hp > 0) {
						hpCells [hp - 1].SetActive (false);
						hp--;
					}
				}
			}
			if (damage_tag == "GoodAttack") 
			{
				for (int i=0; i<50; i++) {
					if (hp > 0) {
						hpCells [hp - 1].SetActive (false);
						hp--;
					}
				}
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
