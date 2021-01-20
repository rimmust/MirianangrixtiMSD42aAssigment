using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    //varible of type gamesession
    GameSession gameSession;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        //is an objet in the hirarchy find it
        gameSession = FindObjectOfType<GameSession>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //updae the text 
        scoreText.text = gameSession.GetScore().ToString();
    }

    

}
