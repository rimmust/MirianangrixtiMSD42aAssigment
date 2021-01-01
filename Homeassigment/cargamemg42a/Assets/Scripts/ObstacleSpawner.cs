using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //choose whic waay the obstacle spawn
    [SerializeField] List<WaveConfigObstc> waveConfigList;

    //start from  wave 0
    int startingWave = 0;



    // Start is called before the first frame update
    void Start()
    {
        //set current wave to wave1 acces the list pos 0
        var currentWave = waveConfigList[startingWave];

        //spawn all obsitcales in currentwave
        StartCoroutine(SpawnAllObstaclesInWave(currentWave));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //courintines

    //say which wave we need to spawn obstacles from
    private IEnumerator SpawnAllObstaclesInWave(WaveConfigObstc waveConfig)
    {
        //spawn  obstacle from waveConfigObstc to pos by the waypoint of the wave 
        //create prefab whic  from wave config add pos of 1 waypoint of the wave spawn
        Instantiate(
            waveConfig.GetObstaclePrefab(),
            waveConfig.GetWaypoints()[0].transform.position,
            Quaternion.identity);
        
        //wait between each spawns  of obstacles
        yield return new WaitForSeconds(waveConfig.GetTimeBetweenSpawns());
    }
    

    
    
}
