using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportPlayer : MonoBehaviour {
    public Collider teleportCol;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider teleportCol)
    {
        if (teleportCol.gameObject.name == "FPSController")
        {
            SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
        }
    }
}
