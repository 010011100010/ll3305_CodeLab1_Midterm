using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
    private AudioSource source;
    public AudioClip[] explosiveClips;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(explosiveClips[Random.Range(0, explosiveClips.Length)]);
        Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
