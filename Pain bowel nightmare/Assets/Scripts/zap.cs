using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zap : MonoBehaviour {
    public ParticleSystem eletrocute;
    private Vector3 emitter;

	// Use this for initialization
	void Start () {
        //eletrocute.enableEmission = false;
        var em = eletrocute.emission;
        em.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        var em = eletrocute.emission;
        emitter = GameObject.Find("shooter").transform.position;
        if (GameObject.Find("plunger rod").GetComponent<equipA2>().equipped == true && Input.GetMouseButton(0))
        {
            em.enabled = true;
        }
            else { em.enabled = false; }

    }
}
