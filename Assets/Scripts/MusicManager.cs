using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicArrey;

    AudioSource audioSORS;
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSORS = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicArrey[level];

        if (thisLevelMusic)
        {
            audioSORS.clip = thisLevelMusic;
            audioSORS.loop = true;
            audioSORS.Play();
        }

    }

    public void changeVolumeFunc(float volumeAmount)
    {
        audioSORS.volume = volumeAmount;
    }

}
