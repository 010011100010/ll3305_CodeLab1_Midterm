using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTarget : baseTarget {
	public float torque = 20;
	// Use this for initialization
	new void Start () {
		base.Start ();
		_health = 20;
	}
	
	// Update is called once per frame
	new void Update () {
		base.Update ();
		//Debug.Log (health);
		float turn = Input.GetAxis ("Horizontal");
		rb.AddTorque (transform.forward * torque * turn);
	}
}
