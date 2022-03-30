using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneScript : MonoBehaviour {

    Animator stoneAnimator;

    void Start()
    {
        stoneAnimator = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D stone_trig)
    {
        print("staying under triiger");
        attackScript attackScriptAccess = stone_trig.gameObject.GetComponent<attackScript>();

        if (attackScriptAccess)
        {
            stoneAnimator.SetTrigger("Stone_Under_Attack");
        }
    }

}
