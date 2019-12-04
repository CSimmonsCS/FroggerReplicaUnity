 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    //random lane; spawn car

    public float spawnDelay = 0.3f;

    float nextTimeToSpawn = 0f;

    public GameObject car;

    //float countDownTimer = 3f;

    public Transform[] spawnPoints;


    private void Update()
    {
        //if (countDownTimer <= 0f)
        //{
        //    SpawnCar();
        //    countDownTimer = 3f;
        //}
        //else
        //{
        //    countDownTimer -= Time.deltaTime;
        //}

        if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
