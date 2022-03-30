using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(attackScript))]
public class foxScript : MonoBehaviour {

    Animator animCompo;
    attackScript accessToAttackScript;

	void Start () {
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

        if (collided_obj.GetComponent<stoneScript>())
        {
            animCompo.SetTrigger("jumpTrigger");
        }
        else
        {
            animCompo.SetBool("isAttacking", true);

            accessToAttackScript.SetCurrentTargetFromAnotherScript(collided_obj);
        }
    }
}
