using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoheiShoot : MonoBehaviour
{
    public GameObject projectile;
    public Vector3 emitter;
    public float bulletForce = 10f;
    public AudioClip pewSound;
    public AudioSource mySource;

    // Use this for initialization
    void Start()
    {
        mySource.clip = pewSound;
    }

    // Update is called once per frame
    void Update()
    {
        emitter = GameObject.Find("BulletShooter").transform.position;

        if (GameObject.Find("Gohei rod").GetComponent<equipA2>().equipped == true && Input.GetMouseButton(0))
        {
            GameObject bullet = Instantiate(projectile, emitter, Quaternion.identity)
               as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.up * bulletForce);
            mySource.PlayOneShot(pewSound);
        }


    }
}