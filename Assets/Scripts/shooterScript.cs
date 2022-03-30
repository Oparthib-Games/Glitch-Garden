using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterScript : MonoBehaviour {

    public GameObject projectiles, instantatePos;

    public GameObject projectileParent;

    private Animator anim;

    private EnemySpawnerScript myLaneSpawner;

    private void Start()
    {
        anim = GetComponent<Animator>();

        projectileParent = GameObject.Find("parentsOfProjectiles");

        if (!projectileParent)
        {
            projectileParent = new GameObject("parentsOfProjectiles");
        }

        SetMyLaneSpawner();
        print(myLaneSpawner);
    }

    private void Update()
    {
        if (IsAttackerInLine())
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }
    }

    void SetMyLaneSpawner()
    {
        EnemySpawnerScript[] spawnerArrey = GameObject.FindObjectsOfType<EnemySpawnerScript>();

        foreach (EnemySpawnerScript theSpawner in spawnerArrey)
        {
            if(theSpawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = theSpawner;
                return;
            }
        }

        Debug.LogError(name + "Can't find spawner in lane");
    }

    bool IsAttackerInLine()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }

        foreach(Transform theAttackerAsChild in myLaneSpawner.transform)
        {
            if(theAttackerAsChild.transform.position.x > transform.position.x)
            {
                return true;
            }
        }

        return false; /*attacker in lane but behind us*/
    }

    private void Fire ()
    {
        GameObject instantiateAsGO = Instantiate(projectiles);
        instantiateAsGO.transform.parent = projectileParent.transform;
        instantiateAsGO.transform.position = instantatePos.transform.position;
    }


}
