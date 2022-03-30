using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_script : MonoBehaviour {

    button_script[] button_Arreys;

    public GameObject myselfDefenderPrefab;

    public static GameObject selectedDefender;

    void Start()
    {
        button_Arreys = FindObjectsOfType<button_script>();
    }

    void OnMouseDown()
    {
        foreach(button_script thisButton in button_Arreys)
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = myselfDefenderPrefab;
    }

}
