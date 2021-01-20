using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPalyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SetUpSingelton();
    }

    private void SetUpSingelton()
    {
        //gets music player object
        if(FindObjectsOfType(GetType()).Length >1)
        {
            //Destroy the last gameobejct
            Destroy(gameObject);
        }
        else
        {
            //protect music player so that it wont be destroyed when changing scenes
            DontDestroyOnLoad(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
