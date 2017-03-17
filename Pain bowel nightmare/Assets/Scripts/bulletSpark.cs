using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpark : MonoBehaviour {
    public GameObject explosion;
    public GameObject spark;
    public Collider bulletCollider;
    public float deathTimer = 3f;

	// Use this for initialization
	void Start () {
        Invoke("StarryExplosion", deathTimer);

    }
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, deathTimer);
	}

    void OnCollisionEnter (Collision bulletCollider)
    {
        Instantiate(spark, bulletCollider.gameObject.transform.position, bulletCollider.gameObject.transform.rotation);
    }

    void StarryExplosion ()
    {
        Instantiate(explosion, bulletCollider.gameObject.transform.position, Quaternion.identity);
    }
}
