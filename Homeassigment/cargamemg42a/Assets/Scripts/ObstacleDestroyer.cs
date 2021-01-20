using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleDestroyer : MonoBehaviour
{
    [SerializeField] int ScoreValue = 5;

    public void ShowWinner()
    {
        if (ScoreValue <= 100)
        {
            print("WINNER");
        }
    }
    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        //destroy the obstacle as they go down after the palyer
        Destroy(otherObject.gameObject);

        //add score to gamesession score
        FindObjectOfType<GameSession>().AddToScore(ScoreValue);

      
    }

   
      
}



