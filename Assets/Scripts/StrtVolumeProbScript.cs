using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrtVolumeProbScript : MonoBehaviour {

	void Start () {
        MusicManager soundManager = FindObjectOfType<MusicManager>();

        soundManager.GetComponent<AudioSource>().volume = PlayerPrefsManager.GetMasterVolume();

    }

    void Update () {
		


	}
}
