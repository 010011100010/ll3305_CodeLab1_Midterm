using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
    public GameObject hinge;
    public GameObject openDoorPrompt;
    public Collider promptCollider;
    public KeyCode openDoorKey = KeyCode.F;
	// Use this for initialization
	void Start () {
        openDoorPrompt.SetActive(false);
	}

    void OnTriggerEnter (Collider promptCollider)
    {
        openDoorPrompt.SetActive(true);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
