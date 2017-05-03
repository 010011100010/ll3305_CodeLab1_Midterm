using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class defeat : MonoBehaviour {
	public Text teleporting;
	private float timer = 10f;
	// Use this for initialization
	void Start () {
		//timer = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		//int countdown = Mathf.RoundToInt (timer - Time.deltaTime);
		//print (timer);
		print (Mathf.Round (timer));
		teleporting.text = "You lost! \n Teleporting to the \n fecal realm of Mr.Leak in: " + Mathf.Round (timer).ToString ();
		if (Mathf.Round (timer) == 0) {
			SceneManager.LoadScene ("scene2", LoadSceneMode.Single);
		}
	}
}
