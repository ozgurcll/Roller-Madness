using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;



    public float time = 5f;
    public float nextTime = 0f;
    public TimeManager timeManager;
    public Transform[] spawnControl;

    
    private void Update()
    {

        if (Time.timeSinceLevelLoad > nextTime && timeManager.win == false)
        {

            nextTime += time;
            SpawnEnemy(enemy, spawnControl[RandomSpawnNumber()]);
        }


    }
    public void SpawnEnemy(GameObject enemySpawn, Transform newTransform)
    {
        Instantiate(enemySpawn, newTransform.position, newTransform.rotation);
    }

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnControl.Length);
    }

    
    
}
