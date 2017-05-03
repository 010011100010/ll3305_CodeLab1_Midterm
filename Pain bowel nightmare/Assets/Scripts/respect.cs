using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respect : MonoBehaviour {
    public Collider soulCol;
    public AudioClip soulClip;
    private AudioSource soulVoice;
    public GameObject soulPrompt;
    private bool soulJudge = false;
	// Use this for initialization
	void Start () {
        soulVoice = GetComponent<AudioSource>();
        soulPrompt.SetActive(false);
        soulJudge = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (soulJudge == true && Input.GetKeyDown(KeyCode.F))
        {
            soulVoice.PlayOneShot(soulClip);
			Invoke ("Gameover", 16f);
        }
	}

    void OnTriggerExit(Collider soulCol)
    {
        soulPrompt.SetActive(false);
        soulJudge = false;
    }

    void OnTriggerEnter (Collider soulCol)
    {
        if (soulCol.gameObject.name == "FPSController") { soulPrompt.SetActive(true); soulJudge = true; }
    }

	void Gameover () {
		SceneManager.LoadScene ("Victory", LoadSceneMode.Single);
	}
}
