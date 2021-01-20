using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDispaly : MonoBehaviour
{
    Text healthText;
    Player player;


    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        //search fro a type player in heirarchy 
        player = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        //updae the text 
       healthText.text = player.GetHealth().ToString();
       
        
    }

}
