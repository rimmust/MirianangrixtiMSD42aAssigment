using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float shotCounter;

    [SerializeField] float minTimeBetweenShots = 0.2f;

    [SerializeField] float maxTimeBetweenShots = 3f;

    [SerializeField] GameObject obstacleLaserPrefab;

   [SerializeField] float laserSpeed = 0.4f;
    
   


    // Start is called before the first frame update
    void Start()
    {
        //random number between 0.2 and 3
        shotCounter = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);


    }

    // Update is called once per frame
    void Update()
    {
        //process obstacle shoots
        CountDownAndShoot();

    }
  


    private void CountDownAndShoot()
    {
        // start counting,everyframe the amount of time for shoot
        shotCounter -= Time.deltaTime;

        if (shotCounter <=0f)
        {
            ObstacleFire();
            // reset the shotCounter, counting down each shoot
            shotCounter = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);

        }

    }

    private void ObstacleFire()
    {
        //get laser prefab shot laser ant obstacle pos
        GameObject obstacleLaser = Instantiate(obstacleLaserPrefab, transform.position, Quaternion.identity) as GameObject;

        obstacleLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -laserSpeed);

    }

    
}
