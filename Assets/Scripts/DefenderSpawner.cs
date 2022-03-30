using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    public Camera myCamera;

    public GameObject DefenderParent;

    starDisplayScript starDisplayScriptAccess;
    defendScript defendScriptAccess;

    void Start()
    {
        DefenderParent = GameObject.Find("parentsOfDefenders");

        if (!DefenderParent)
        {
            DefenderParent = new GameObject("parentsOfDefenders");
        }

        starDisplayScriptAccess = GameObject.FindObjectOfType<starDisplayScript>();
    }

    void OnMouseDown()
    {
        //print(Input.mousePosition);
        //print(CalculateWorldPointOfMouseClick());
        print(GetIntValueOfMethodBelow(CalculateWorldPointOfMouseClick()));

        GameObject selectedDefenderAccess = button_script.selectedDefender;

        int defenderCost = selectedDefenderAccess.GetComponent<defendScript>().starCost;

        if (starDisplayScriptAccess.UseStarts(defenderCost) == starDisplayScript.spawnStatus.SUCCESS)
        {
            SpawnDefender();
        }
        else
        {
            Debug.LogError("insuffecient stars");
        }
    }

    void SpawnDefender()
    {
        Vector2 instantiatePosition = GetIntValueOfMethodBelow(CalculateWorldPointOfMouseClick());

        GameObject spawnAsGO = (Instantiate(button_script.selectedDefender, instantiatePosition, Quaternion.identity));

        spawnAsGO.transform.parent = DefenderParent.transform;
    }

//-------------------------------------------------------------------------------------------------------------------

    Vector2 GetIntValueOfMethodBelow (Vector2 anyParaMeterToPassValouOfMethodBelow_03)
    {
        float newX = Mathf.RoundToInt(anyParaMeterToPassValouOfMethodBelow_03.x);
        float newY = Mathf.RoundToInt(anyParaMeterToPassValouOfMethodBelow_03.y);


        return new Vector2(newX, newY);
    }

//-------------------------------------------------------------------------------------------------------------------

    Vector2 CalculateWorldPointOfMouseClick ()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        /*Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 screenSpaceToWorldSpace = myCamera.ScreenToWorldPoint(weirdTriplet);*/

        Vector3 screenSpaceToWorldSpace = myCamera.ScreenToWorldPoint(new Vector3(mouseX, mouseY, distanceFromCamera));

        return screenSpaceToWorldSpace;
    }

}
