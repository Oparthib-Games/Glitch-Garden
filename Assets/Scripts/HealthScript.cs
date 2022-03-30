using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public float Health;

    public void DealDamage (float damageAmount)
    {
        Health -= damageAmount;

        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
