using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInScript : MonoBehaviour {

    public float fadeInTime;

    public Color colorChangerVariable = Color.black;

    Image fadePanel;


    void Start () {
        fadePanel = GetComponent<Image>();
	}
	
	void Update () {
        if(Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChangeRate = Time.deltaTime / fadeInTime;
            colorChangerVariable.a -= alphaChangeRate;
            fadePanel.color = colorChangerVariable;
        }
        else
        {
            gameObject.SetActive(false);
        }

	}
}
