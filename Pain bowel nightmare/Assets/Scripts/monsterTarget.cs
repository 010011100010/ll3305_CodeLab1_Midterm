using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterTarget : baseTarget {

	// Use this for initialization
	new void Start () {
		base.Start ();
		_health = 40;
	}
	
	// Update is called once per frame
	new void Update () {
		
	}

	new void Die () {
		GameObject deathExplosion = Instantiate(explosions[Random.Range(0, explosions.Length)], GameObject.Find("Monster explosion").transform.localPosition, Quaternion.identity) as GameObject;
		deathExplosion.transform.localScale = new Vector3 (20, 20, 20);
		Destroy (gameObject);
	}
}
