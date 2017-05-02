using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class spawnManager : MonoBehaviour {
	//public int timer = 300;
	public GameObject[] spawnLocation;
	public GameObject[] targets;
	public GameObject[] explosions;
	public Text destroyCount;
	public Text missedCount;
	private int targetCount = 5;
	private int count;
	private int missedInt;
	private int i;
	/*int _timer = 3000;
	public int timer
	{
		get {return _timer;}

		set {if (value <= 0) 
			{
				_timer = 0;
		} else {_timer = value;}
		}
	}*/
	// Use this for initialization
	void Start () {
		//missedCount = GameObject.Find ("Target missed");
		count = 0;
		missedInt = 0;
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		/*timer -= Mathf.RoundToInt(Time.deltaTime*60);
		//print (Time.fixedDeltaTime);
		//Debug.Log (Time.deltaTime);
		//print (Mathf.RoundToInt (Time.deltaTime));
		//print (timer);
		if (timer !=0 && timer % 20 == 0) {
			Instantiate (targets[Random.Range(0, targets.Length)], spawnLocation[Random.Range(0, spawnLocation.Length)].transform.position, Quaternion.identity);
			print ("Target spawned!");
		}
	}*/

		for (i; i<targetCount; i++){
			if (GameObject.FindGameObjectWithTag("Monster") == null){
				Instantiate (targets[Random.Range(0, targets.Length)], spawnLocation[Random.Range(0, spawnLocation.Length)].transform.position, Quaternion.identity);
				print ("Target spawned!");
				print (i);
				GameObject.Find ("FPSController").SendMessage ("SpawnText");
			}
		}
	}

	void SetCount () {
		count = count + 1;
		destroyCount.text = "Targets destroyed: " + count.ToString () + "/" + targetCount.ToString ();
	}

	void MissedCount () {
		missedInt = missedInt + 1;
		missedCount.text = "Targets missed: " + missedInt.ToString ();
		GameObject.Find ("FPSController").SendMessage ("ErrorText");
	}
}
