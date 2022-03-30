using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_value";
    const string DIFFICULT_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";


    public static void SetMasterVolume (float volume)
    {
        if(volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume out of range");
        }
    }

    public static float GetMasterVolume ()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    //==========================================================================================

    public static void UnlockLevel (int lVl)
    {
        if(lVl <= Application.levelCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + lVl.ToString(), 1);
        }
        else
        {
            Debug.LogError("Trying to unlock level not in build order");
        }
    }

    public static bool GetIsLevelUnlocked(int lVl)
    {
        int lVlintValue = PlayerPrefs.GetInt(LEVEL_KEY + lVl.ToString());
        bool intToBool = (lVlintValue == 1);

        if(lVl <= Application.levelCount -1)
        {
            return intToBool;
        }
        else
        {
            Debug.LogError("Trying to query level not in build order");
            return false;
        }
    }
    //==========================================================================================

    public static void SetDifficulty(float diff)
    {
        if (diff >= 1 && diff<=3)
        {
            PlayerPrefs.SetFloat(DIFFICULT_KEY, diff);
        }
        else
        {
            Debug.LogError("Difficulty Out Of Range");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULT_KEY);
    }
}
