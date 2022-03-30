using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_SCRIPT : MonoBehaviour {

    void Start () {
        print(PlayerPrefsManager.GetMasterVolume());
        PlayerPrefsManager.SetMasterVolume(0.5f);
        print(PlayerPrefsManager.GetMasterVolume());
        PlayerPrefsManager.SetMasterVolume(2f);
        print(PlayerPrefsManager.GetMasterVolume());

        print(PlayerPrefsManager.GetIsLevelUnlocked(1));
        PlayerPrefsManager.UnlockLevel(1);
        print(PlayerPrefsManager.GetIsLevelUnlocked(1));

        print(PlayerPrefsManager.GetDifficulty());
        PlayerPrefsManager.SetDifficulty(9);
        print(PlayerPrefsManager.GetDifficulty());

    }

    void Update () {
		
	}
}
