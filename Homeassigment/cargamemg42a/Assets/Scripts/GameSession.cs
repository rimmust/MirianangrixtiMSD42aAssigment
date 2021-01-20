using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        SetUpSingelton();
    }

    private void SetUpSingelton()
    {
        //get the number of game sessions

        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;
        
        //to make sure that only 1 game obejct is running 
        if (numberOfGameSessions > 1) 
        {
            // it the number of session is bigger than 1 destroy the last game object
            Destroy(gameObject);
        }

        else
        {

            DontDestroyOnLoad(gameObject);
        }
            
    }

    public int GetScore()
    {
        return score;
    }


   //get score value from out side th escript and add it to our score
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }


    //to reset the game 
    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
