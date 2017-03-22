using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterSpawn : MonoBehaviour {
    public GameObject monster;
    public GameObject spawn;
    private Collider trapCol;
	// Use this for initialization
	void Start () {
        trapCol = GetComponent<Collider>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider trapCol)
    {
        if (trapCol.gameObject.name == "FPSController")
        {
            Instantiate(monster, spawn.transform.position, Quaternion.identity);
            print("trap activated!");
        }
    }
}
