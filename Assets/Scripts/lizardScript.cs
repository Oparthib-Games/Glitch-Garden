using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizardScript : MonoBehaviour {

    Animator animCompo;
    attackScript accessToAttackScript;

    void Start()
    {
        animCompo = GetComponent<Animator>();

        accessToAttackScript = GetComponent<attackScript>();
    }

    public void OnTriggerEnter2D(Collider2D trig)
    {
        GameObject collided_obj = trig.gameObject;

        if (!collided_obj.GetComponent<defendScript>())
        {
            return;
        }
        animCompo.SetBool("isAttacking", true);
        accessToAttackScript.SetCurrentTargetFromAnotherScript(collided_obj);
    
    }
}
