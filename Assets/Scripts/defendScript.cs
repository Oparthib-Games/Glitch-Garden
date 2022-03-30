using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defendScript : MonoBehaviour {

    starDisplayScript starDisplayAccess;

    public int starCost;

    private void Start()
    {
        starDisplayAccess = FindObjectOfType<starDisplayScript>();
    }

    void AddStars(int starsPoint)
    {
        starDisplayAccess.AddStarts(starsPoint);
    }

}
