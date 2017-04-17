using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamGun : MonoBehaviour {
    LineRenderer line;
    public GameObject beamSpark;
    public AudioClip beamFire;
    private AudioSource audio;
    // Use this for initialization
    void Start () {
        line = gameObject.GetComponent<LineRenderer>();
        line.enabled = false;
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("makarov").GetComponent<equipA2>().equipped == true && Input.GetMouseButton(0)) {
            audio.PlayOneShot(beamFire, 1f);
            line.enabled = true;
            Ray beamRay = new Ray(transform.position, -transform.forward);
            RaycastHit Hit;
            line.SetPosition(0, beamRay.origin);
            if (Physics.Raycast(beamRay, out Hit, 100))
                line.SetPosition(1, Hit.point);
            else line.SetPosition(1, beamRay.GetPoint(100));
            Instantiate(beamSpark, Hit.point, Quaternion.identity);

            Invoke("BeamOff", 0.1f);
        }
        
    }

    public void BeamOff()
    {
        line.enabled = false;
    }
}
