using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour {

    public float projectileSpeed;

	void Start () {
		
	}
	
	void Update () {

        transform.Translate (Vector3.right * projectileSpeed * Time.deltaTime);

	}

    private void OnTriggerEnter2D(Collider2D projectile_Trig)
    {
        attackScript attackAccess = projectile_Trig.gameObject.GetComponent<attackScript>();

        HealthScript healthAccess = projectile_Trig.gameObject.GetComponent<HealthScript>();

        if (attackAccess && healthAccess)
        {
            healthAccess.DealDamage(55);
            Destroy(gameObject);
        }
    }
}
