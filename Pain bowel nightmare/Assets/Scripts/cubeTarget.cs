using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTarget : baseTarget {

	// Use this for initialization
	new void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	new void Update () {
		base.Update ();
		Debug.Log (health);
	}
}
