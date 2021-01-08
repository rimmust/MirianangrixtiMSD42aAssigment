using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints; //to move the waypoints 
  //  [SerializeField] float obstacleMoveSpeed = 2f;

    [SerializeField] WaveConfigObstc waveConfig; //link them together

    //update to next waypoint
    int waypointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        //gets the way point in paths and return  them in this varible
        waypoints = waveConfig.GetWaypoints();

        //the obstcacle start on waypoint 0
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obstacleMove();
    }

    private void obstacleMove()
    {
        if (waypointIndex <= waypoints.Count -1)
        {
            // to get  tragetpositon to the next waypoint that we whant to go
            var targetPosition = waypoints[waypointIndex].transform.position;

            targetPosition.z = 0f; //to set the z position to 0

            //get the movement speed from the wave
            var obstacleMovement = waveConfig.GetObstcaleMoveSpeed() * Time.deltaTime;

            // obsctale move from curent positon to positon at obsctacleMovementSpeed
           transform.position= Vector2.MoveTowards(transform.position, targetPosition, obstacleMovement);

            // to check  target position
            if (transform.position == targetPosition)
            {
                waypointIndex++; // inrement by 1
            }
        }

        else
        {
            //arrange something in here to make the enimes move down after the player
          Destroy(gameObject); 
           
        }

       
    }

    // do the waveconfig to set 
        public void SetWaveConfig(WaveConfigObstc waveConSet)
    {
        waveConfig = waveConSet;
    }

}
