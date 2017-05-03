using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class baseTarget : MonoBehaviour {

    protected string name = "Basic Target";
    public float moveSpeed = 2f;
	protected Rigidbody rb;
	protected GameObject[] explosions;
	private Vector3 zero;

	protected float _health = 10f;
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

	protected float _timer = 12f;
	public float timer
	{
		get { return _timer;}
		set 
		{ 
			if (value < 0f) {
				value = 0;
				Disappear ();
			} else {
				_timer = value;
			}
		}
	}

    public virtual void Start ()
    {
        rb = GetComponent<Rigidbody>();
		explosions = GameObject.Find ("Spawn Manager").GetComponent<spawnManager> ().explosions;
		zero = new Vector3 (0, 0, 0);

    }

    public virtual void Update ()
    {
		rb.velocity = new Vector3(moveSpeed * (Mathf.PerlinNoise(Time.timeSinceLevelLoad, 0) - 0.5f) * 2, moveSpeed * (Mathf.PerlinNoise(0, Time.timeSinceLevelLoad) - 0.5f) * 2, moveSpeed * (Mathf.PerlinNoise(0, Time.timeSinceLevelLoad) - 0.5f) * 2);
		timer -= Time.deltaTime;
		//print (timer);
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
		GameObject.Find ("Spawn Manager").SendMessage ("SetCount");
    }

	protected virtual void HitByRay()
	{
		health -= 2f;
	}

	protected void Disappear () {
		gameObject.transform.DOScale (zero, 2f);
		Destroy (gameObject);
		GameObject.Find ("Spawn Manager").SendMessage ("MissedCount");

	}
}
