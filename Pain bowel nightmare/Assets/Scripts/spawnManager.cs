using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour {
	//public int timer = 300;
	public GameObject[] spawnLocation;
	public GameObject[] targets;
	public GameObject[] explosions;

	int _timer = 3000;
	public int timer
	{
		get {return _timer;}

		set {if (value <= 0) 
			{
				_timer = 0;
		} else {_timer = value;}
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Mathf.RoundToInt(Time.deltaTime*60);
		//print (Time.fixedDeltaTime);
		//Debug.Log (Time.deltaTime);
		//print (Mathf.RoundToInt (Time.deltaTime));
		//print (timer);
		if (timer !=0 && timer % 20 == 0) {
			Instantiate (targets[Random.Range(0, targets.Length)], spawnLocation[Random.Range(0, spawnLocation.Length)].transform.position, Quaternion.identity);
			print ("Target spawned!");
		}
	}
}
