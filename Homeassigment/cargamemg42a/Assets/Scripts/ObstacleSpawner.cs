using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //choose whic waay the obstacle spawn
    [SerializeField] List<WaveConfigObstc> waveConfigList;
    
    //to loop everytime starts
    [SerializeField] bool looping = false;

    //start from  wave 0
    int startingWave = 0;



    // Start is called before the first frame update
     IEnumerator Start()  //the start will become a coututine to loop 
    {
        do
        {
            //spawn all obsitcales in currentwave

            yield return StartCoroutine(SpawnAllWaves());
        }
        // then it will continue  until the courutine finishes
        while (looping ); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //courintines

    //say which wave we need to spawn obstacles from
    private IEnumerator SpawnAllObstaclesInWave(WaveConfigObstc waveToSpawn)
    {
        // to start get the number of obstacles,to come after each other in wave
        for (int obstacleCount = 1; obstacleCount <= waveToSpawn.GetNumberOfObstacles(); obstacleCount++)
        {
            //spawn  obstacle from waveConfigObstc to pos by the waypoint of the wave 
            //create prefab whic  from wave config add pos of 1 waypoint of the wave spawn
           var newObstacle=         Instantiate(
                                waveToSpawn.GetObstaclePrefab(),
                                waveToSpawn.GetWaypoints()[0].transform.position,
                                 Quaternion.identity);

            //wave selcted and the obstcale that it has
            newObstacle.GetComponent<EnemyPathing>().SetWaveConfig(waveToSpawn);


            //wait between each spawns  of obstacles
            yield return new WaitForSeconds(waveToSpawn.GetTimeBetweenSpawns());
        }

    }
    
    //courintine

    private IEnumerator SpawnAllWaves()
    {
        //to spawn all obstacles in wave

        foreach(WaveConfigObstc currentObstacle in waveConfigList)
        {
            //for each wave in list spawn the obstacles then spawn wave2 and repeat
            {
                yield return StartCoroutine(SpawnAllObstaclesInWave(currentObstacle));
            }
           
        }
    }
    


}
