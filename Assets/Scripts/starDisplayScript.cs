using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starDisplayScript : MonoBehaviour {

    Text starText;

    int starValue = 100;
    
    public enum spawnStatus { SUCCESS, FAILURE};

    void Start()
    {
        starText = GetComponent<Text>();

        UpdateStarDisplay();
    }

    public void AddStarts (int point_ADD_Amount)
    {
        starValue += point_ADD_Amount;

        UpdateStarDisplay();
    }

    public spawnStatus UseStarts (int point_Khoroch_Amount)
    {
        if(starValue >= point_Khoroch_Amount)
        {
            starValue -= point_Khoroch_Amount;

            UpdateStarDisplay();

            return spawnStatus.SUCCESS;
        }

        return spawnStatus.FAILURE;
        
    }

    void UpdateStarDisplay()
    {
        starText.text = starValue.ToString();
    }
}
