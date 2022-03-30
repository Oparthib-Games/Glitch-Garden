using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject[] attackerPrefabArrey;

    private void Update()
    {
        foreach (GameObject thisAttacker in attackerPrefabArrey)
        {
            if (isTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
    }

    void Spawn(GameObject myGameObject)
    {
        GameObject attackerAsGO = Instantiate(myGameObject);
        attackerAsGO.transform.position = transform.position;
        attackerAsGO.transform.parent = transform;
    }

    bool isTimeToSpawn(GameObject attackerGameObject)
    {
        attackScript attackScriptAccess = attackerGameObject.GetComponent<attackScript>();

        float meanSpawnDelay = attackScriptAccess.seenEverySeconds;
        float spawnPerSecond = 1 / meanSpawnDelay; //$$$$ to reduce the whole number below 1 $$$$

        if(Time.deltaTime > meanSpawnDelay)        //$$$$ to check is the number is below 1 after dividing by 1 $$$$
        {
            Debug.LogError("Spawn rate by frame");
        }

        float threshold = spawnPerSecond * Time.deltaTime /5 ;

        //if(Random.value < threshold)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
        return (Random.value < threshold);
    }

//-------------------------------------------------------------------------------------------------------------------

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector2(1, 1));
    }

}
