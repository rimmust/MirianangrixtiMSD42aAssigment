using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    // the speed the player move
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float padding = 0.5f;
    float xMin, xMax, yMin, yMax;
    [SerializeField] float health = 50f;



    // Start is called before the first frame update
    void Start()
    {
        SetUpMoveBoundaries();
        
    }

    
    // Update is called once per frame
    void Update()
    {
        Pmove();  
    }

    //reduce the heath if obstacle bullets collide with player
    //which has dameage dealer 

   private void OnTriggerEnter2D(Collider2D otherObject)
  {
        //go in damage dealer class 
        //reduce the health accordingly
        DamgeDealer dmgDealer = otherObject.gameObject.GetComponent<DamgeDealer>();

        
        //if they object doesn not have a damgdelaer ignore it
        if(!dmgDealer) //if dmgdealer is 
        {
            return;
        }

       

        ProcesHit(dmgDealer);

        
   }

    //ifit is called ,damageDealer details
private void ProcesHit(DamgeDealer dmgDealer)
   {
       health -= dmgDealer.GetDamage();

       if (health <=0)
      {
        Destroy(gameObject);
      }
            
  }
    private void SetUpMoveBoundaries()
    {
        // save the main camera in varibles
        Camera gameCamera = Camera.main;

        //the min is 0 max is 1

        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding; //change 1 to 0.5f timxi san nofs lscrn


    }


    private void Pmove()
    {
        //make the player move to check its x position   tomove to left to righ slowly
        var delataX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //check  current the player position    differnet new position
        var newXPos = transform.position.x + delataX;
        newXPos = Mathf.Clamp(newXPos, xMin, xMax); //clamp positon betwwen 0 and 1 on camera

        // i dont now if needed to move in y      tomove slowly
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ; 
        var newYPos = transform.position.y + deltaY;
        newYPos = Mathf.Clamp(newYPos, yMin, yMax);

        //move it ony in the y axis
        this.transform.position = new Vector2(newXPos,newYPos); //transfrom.postion.y

      

       }
}
