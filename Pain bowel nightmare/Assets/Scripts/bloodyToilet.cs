using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodyToilet : MonoBehaviour {
    public Collider bloodCollider;
    public KeyCode openDoorKey = KeyCode.F;
    public Transform bloodSpawn;
    public GameObject bloodPrompt;
    public GameObject bloodVFX;
    private bool canThisDoorBeOpened = false;
    public AudioClip noise;
    //private bool alreadyOpen = false;

    // Use this for initialization
    void Start () {
        bloodPrompt.SetActive(false);
        canThisDoorBeOpened = false;

    }

    void OnTriggerEnter (Collider bloodCollider)
    {
        if (bloodCollider.gameObject.name == "FPSController")
        {
            bloodPrompt.SetActive(true);
            canThisDoorBeOpened = true;
        }
    }

    void OnTriggerExit (Collider bloodCollider)
    {
        if (bloodCollider.gameObject.name == "FPSController")
        {
            bloodPrompt.SetActive(false);
            canThisDoorBeOpened = false;
        }
    }

    // Update is called once per frame
    void Update () {
		if (canThisDoorBeOpened == true && Input.GetKeyDown(openDoorKey))
        {
            Instantiate(bloodVFX, bloodSpawn.transform.position, bloodSpawn.transform.rotation);
            Destroy(bloodVFX,5);
            AudioSource.PlayClipAtPoint(noise, transform.position);
        }
	}
}
