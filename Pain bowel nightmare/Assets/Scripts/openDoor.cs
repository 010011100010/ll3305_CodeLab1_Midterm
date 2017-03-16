using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
    public GameObject hinge;
    public GameObject openDoorPrompt;
    public Collider promptCollider;
    public float openDoorDegree = 120f;
    public float openDoorTime = 3f;
    public float closeDoorDegree = -120;
    public KeyCode openDoorKey = KeyCode.F;
    private bool canThisDoorBeOpened = false;
    private bool alreadyOpen = false;
    private Quaternion defaultRotation;
    private Quaternion openRotation;
	// Use this for initialization
	void Start () {
        openDoorPrompt.SetActive(false);
        canThisDoorBeOpened = false;
        //defaultRotation = hinge.transform.eulerAngles;
        //openRotation = new Vector3(defaultRotation.x, defaultRotation.y + openDoorDegree, defaultRotation.z);
    }

    void OnTriggerEnter (Collider promptCollider)
    {
        if (promptCollider.gameObject.name == "FPSController")
        {
            canThisDoorBeOpened = true;
            openDoorPrompt.SetActive(true);
        }

    }

    void OnTriggerExit (Collider promptCollider)
    {
        if (promptCollider.gameObject.name == "FPSController")
        {
            openDoorPrompt.SetActive(false);
            canThisDoorBeOpened = false;
        }
    }

    // Update is called once per frame
    void Update () {
        /*if (canThisDoorBeOpened == true && Input.GetKey(openDoorKey)) {
            openTheGodDamnDoor();
            alreadyOpen = true;
        }

        if (canThisDoorBeOpened == true && alreadyOpen == true && Input.GetKey(openDoorKey))
        {
            closeDoor();
            alreadyOpen = false;
        }*/

        if (alreadyOpen == true)
        {
            openRotation = Quaternion.Euler(0, openDoorDegree, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, openRotation, Time.deltaTime * openDoorTime);
        }
        if (alreadyOpen == false)
        {
            defaultRotation = Quaternion.Euler(0, closeDoorDegree, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, defaultRotation, Time.deltaTime * openDoorTime);
        }

        if (canThisDoorBeOpened == true)
        {
            if (Input.GetKeyDown(openDoorKey))
            { alreadyOpen = !alreadyOpen; }
        }
	}

    void openTheGodDamnDoor ()
    {
        /*for (float i=0; i<openDoorDegree; i+=Time.deltaTime*openDoorTime)
        {
            hinge.transform.Rotate(0, Time.deltaTime*openDoorTime, 0);
        }*/
        //transform.Rotate(0, Time.deltaTime, 0);


        //transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRotation, Time.deltaTime * openDoorTime);
    }

    void closeDoor ()
    {
        //hinge.transform.Rotate(0, closeDoorDegree, 0);
        //transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRotation, Time.deltaTime * openDoorTime);
    }
}
