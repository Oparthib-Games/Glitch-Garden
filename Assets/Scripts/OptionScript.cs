using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OptionScript : MonoBehaviour {

    public Slider volumeSlider, diffSlider;

    public LevelManagerScript levelManager;
    private MusicManager soundManager;
    

    void Start()
    {
        soundManager = GameObject.FindObjectOfType<MusicManager>();

        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();

        diffSlider.value = PlayerPrefsManager.GetDifficulty();
    }

    void Update()
    {
        soundManager.changeVolumeFunc(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);

        PlayerPrefsManager.SetDifficulty(diffSlider.value);

        levelManager.loadLevelFunction("StartMenu");
    }

    public void SetDifault()
    {
        //$$$$ this function is not a part of PlayerPrefs $$$$
        volumeSlider.value = 0.7f;
        diffSlider.value = 2;
    }
}
