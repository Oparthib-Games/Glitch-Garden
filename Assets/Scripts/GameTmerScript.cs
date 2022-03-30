using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTmerScript : MonoBehaviour {

    public float levelLifeSpan = 100;
    //public float secondsLeft;

    bool isEndOfLevel = false; //$$$$ to avoid update same thing again and again and again.

    Slider slider;

    private AudioSource quest_Complete_audio;

    private LevelManagerScript levelManagerAccess;

    GameObject winLabel;

	void Start () {
        slider = GetComponent<Slider>();

        //secondsLeft = levelLifeSpan;

        quest_Complete_audio = GetComponent<AudioSource>();
        levelManagerAccess = GameObject.FindObjectOfType<LevelManagerScript>();

        winLabel = GameObject.Find("winLabel");
        winLabel.SetActive(false);

        print(quest_Complete_audio.clip.length);
    }
	
	void Update () {
        //slider.value = 1 - (secondsLeft / levelLifeSpan); // to get the value below 1. the slider only goes from 0 to 1.
        slider.value = Time.timeSinceLevelLoad / levelLifeSpan; // to get the value below 1. the slider only goes from 0 to 1.
        
        if(Time.timeSinceLevelLoad >= levelLifeSpan && !isEndOfLevel)
        {
            quest_Complete_audio.Play();
            Invoke("LoadNextLevelAfterWin", quest_Complete_audio.clip.length);
            isEndOfLevel = true;

            winLabel.SetActive(true);
        }

    }

    void LoadNextLevelAfterWin()
    {
        levelManagerAccess.loadNextLevelFunc();
    }
}
