using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class slideDoorOpposite : MonoBehaviour {

	private Vector3 slideInPos;
	private Collider doorTrigger;
	// Use this for initialization
	void Start () {
		slideInPos = transform.position + new Vector3(0, 0, -3);
		doorTrigger = GetComponentInParent<Collider>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter()
	{
		print("Open door");
		gameObject.transform.DOMove(slideInPos, 0.5f);
		Invoke("Close", 2);
	}

	void Close()
	{
		gameObject.transform.DOMove(slideInPos - new Vector3(0, 0, -3), 0.5f);
	}
}
