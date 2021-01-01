using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Obstacle Wave Config")]
public class WaveConfigObstc : ScriptableObject
{
    // obsctacles that will spawn in the wave
    [SerializeField] GameObject obstaclePrefab;

    // path the obstacle will go
    [SerializeField] GameObject pathPrefab;

    //  time  between  each obstacle spawn
    [SerializeField] float timeBetweenSpawns = 0.5f;

    //random different time that obstacles spawn
    [SerializeField] float spawnRandomFactor = 0.3f;

    //number of obstacles in the wave
    [SerializeField] int numberOfObstacles = 5;

    // speed of obstcales
    [SerializeField] float obstacleMoveSpeed = 2f;

    //encapsulated methods

    public GameObject GetObstaclePrefab()
    {
        return obstaclePrefab;
    }

    public List<Transform>  GetWaypoints() //we do transform becasue we save waypoint in it
    {
        //different waypoints of waves
        var waveWayPoints = new List<Transform>();

        // go on pathe prefab,add each child to the list waypoint
        //goes on path0, finds waypoint 1,2,3
        foreach (Transform child in pathPrefab.transform)
        {
            waveWayPoints.Add(child);
        }

        //return the list withwaypoints
        return waveWayPoints; 

    }

    public float GetTimeBetweenSpawns()
    {
        return timeBetweenSpawns;
    }

    public float GetSpawnRandomFactor()
    {
        return spawnRandomFactor;
    }

    public int GetNumberOfObstacles()
    {
        return numberOfObstacles;
    }


    public float GetObstcaleMoveSpeed()
    {
        return obstacleMoveSpeed;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
