using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpark : MonoBehaviour
{
    public GameObject explosion;
    public GameObject spark;
    public Collider bulletCollider;
    public float deathTimer = 3f;
    public float radius = 5f;
    public float power = 10f;
    public AudioClip explosionClip;
    public AudioSource explosionSource;

    // Use this for initialization
    void Start()
    {
        //Invoke("StarryExplosion", deathTimer);

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, deathTimer);
    }

    void OnCollisionEnter(Collision bulletCollider)
    {
        Instantiate(spark, bulletCollider.gameObject.transform.position, bulletCollider.gameObject.transform.rotation);
    }

    void StarryExplosion()
    {
        Instantiate(explosion, bulletCollider.gameObject.transform.position, Quaternion.identity);
        explosionSource.PlayOneShot(explosionClip);
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);

        }
    }
}
