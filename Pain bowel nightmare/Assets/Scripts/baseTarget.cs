using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseTarget : MonoBehaviour {

    protected string name = "Basic Target";
    public float moveSpeed = 2f;
    private Rigidbody rb;
    public GameObject[] explosions;

	float _health = 10f;
    public float health
    {
        get { return _health; }
        set
        {
            //Debug.Log("Current health: " + value);

            if (value <= 0f)
            {
                Die();
            }

            else
                _health = value;
        }
    }

    public virtual void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void Update ()
    {
		rb.velocity = new Vector3(moveSpeed * (Mathf.PerlinNoise(Time.timeSinceLevelLoad, 0) - 0.5f) * 2, moveSpeed * (Mathf.PerlinNoise(0, Time.timeSinceLevelLoad) - 0.5f) * 2, moveSpeed * (Mathf.PerlinNoise(0, Time.timeSinceLevelLoad) - 0.5f) * 2);
    }

	protected virtual void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Bullet") {
			health -= 5f;
		}
	}

    protected virtual void Die()
    {
        Instantiate(explosions[Random.Range(0, explosions.Length)], transform.position, Quaternion.identity);
		Destroy (gameObject);
    }
}
