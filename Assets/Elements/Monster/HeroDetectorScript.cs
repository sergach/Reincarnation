using UnityEngine;
using System.Collections;

public class HeroDetectorScript : MonoBehaviour {

	public Transform originTransform;
	public LayerMask opacityLayerMask;

	private GameObject hero;
	private bool isHeroInCollider = false;
	private bool isDetecting = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isHeroInCollider) {
			Vector3 origin = originTransform.position;
			Vector3 direction = hero.transform.position - origin;
			float distance = direction.magnitude;
			int layerMask = opacityLayerMask.value;
			if (!Physics2D.Raycast(origin, direction, distance, layerMask)) {
				Debug.DrawLine(origin, hero.transform.position);
				isDetecting = true;
			} else {
				Debug.DrawLine(origin, hero.transform.position, Color.red);
				isDetecting = false;
			}
		}
	}

	public GameObject GetHero(){
		return hero;
	}

	public bool IsDetecting() {
		return isDetecting;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if ("Hero".Equals(other.gameObject.tag)) {
			hero = other.gameObject;
			isHeroInCollider = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.tag.Equals ("Hero")) {
			isHeroInCollider = false;
			isDetecting = false;
		}
	}
}
