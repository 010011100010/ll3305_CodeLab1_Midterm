﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiEasy : MonoBehaviour {
    private float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform fpsTarget;
    public Rigidbody theRigidbody;
    public Renderer myRenderer;

	// Use this for initialization
	void Start () {
        //myRenderer = GetComponent<Renderer>();
        //theRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if (fpsTargetDistance < enemyLookDistance)
        {
            LookAtPlayer();
            Debug.Log("Look at player");
        }

        if (fpsTargetDistance < attackDistance)
        {
            Attack();
            print("Attacking player!");
        }
	}

    void LookAtPlayer() {
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
    }

    void Attack()
    {

    }
}