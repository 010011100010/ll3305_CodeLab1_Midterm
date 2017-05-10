using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defecate : MonoBehaviour {
    public GameObject fecalParent;
    public float speed = 20f;
    public float spreadFactor = 0.1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion pelletRotation = transform.rotation;
            pelletRotation.x += Random.Range(-spreadFactor, spreadFactor);
            pelletRotation.y += Random.Range(-spreadFactor, spreadFactor);
            pelletRotation.z += Random.Range(-spreadFactor, spreadFactor);
            GameObject fecalClump = Instantiate(fecalParent, transform.position, pelletRotation) as GameObject;
            Rigidbody fecalRb = fecalClump.GetComponent<Rigidbody>();
            fecalRb.velocity = transform.up * speed;
            print("defecating");
        }
	}
}
