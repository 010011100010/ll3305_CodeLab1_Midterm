using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youDied : MonoBehaviour {
    public Collider killCol;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider killCol)
    {
        if (killCol.gameObject.tag == "Monster")
        {
            SceneManager.LoadScene("scene1", LoadSceneMode.Single);
            print("Player is attacked!");
        }
    }
}
