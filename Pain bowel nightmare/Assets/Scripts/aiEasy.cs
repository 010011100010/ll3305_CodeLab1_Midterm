using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiEasy : MonoBehaviour {
    private float fpsTargetDistance;
    private CharacterController character;

    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    private Transform fpsTarget;
    public Rigidbody theRigidbody;
    public Renderer myRenderer;
    public AudioSource monsterSource;
    public AudioClip monsterClip;

	// Use this for initialization
	void Start () {
        //myRenderer = GetComponent<Renderer>();
        //theRigidbody = GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
        fpsTarget = GameObject.Find("FPSController").transform;
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
        //transform.Translate(new Vector3(enemyMovementSpeed, 0, 0));
        //transform.position += transform.forward * enemyMovementSpeed * Time.deltaTime;
        monsterSource.PlayOneShot(monsterClip);
    }
}
