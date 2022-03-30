using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour {
    public float AutoloadLevelTime;


    void Awake()
    {
        if(AutoloadLevelTime == 0)
        {
            print("auto load level disable.");
        }
        else
        {
            Invoke("loadNextLevelFunc", AutoloadLevelTime);
        }
    }

    public void loadNextLevelFunc()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void loadLevelFunction(string levelName)
    {
        Application.LoadLevel(levelName);
    }

    public void QuitGameFunction()
    {
        Application.Quit();
    }

}
