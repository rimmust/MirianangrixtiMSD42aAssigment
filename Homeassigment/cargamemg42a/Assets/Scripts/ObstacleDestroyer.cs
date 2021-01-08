using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        //destroy the obstacle as they go down after the palyer
        Destroy(otherObject.gameObject);
    }
}
