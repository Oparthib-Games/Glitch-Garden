using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class attackScript : MonoBehaviour {

    [Range(-1, 2)]          public float walkSpeed;

    [Tooltip("SECONDS BETWEEN NEXT APPEARANCES")]      public float seenEverySeconds;

    GameObject currentTarget;
    private Animator Onim;





	void Start () {
        //Rigidbody2D RB = gameObject.AddComponent<Rigidbody2D>();         added to requiredcompo  bilow the class

        Onim = GetComponent<Animator>();
    }
	
	void Update () {

        transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);

        if (!currentTarget)
        {
            Onim.SetBool("isAttacking", false);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void setWalkSpeed(float speedInAnimation)
    {
        walkSpeed = speedInAnimation;
    }

    public void StrikeCurrentTarget( float damageAmount)
    {

        if (currentTarget)
        {
            HealthScript healthAccess = currentTarget.GetComponent<HealthScript>();

            if (healthAccess)
            {
                healthAccess.DealDamage(damageAmount);
            }
        }
    }

    public void SetCurrentTargetFromAnotherScript(GameObject anyParameter_02)
    {
        currentTarget = anyParameter_02;
    }

}
