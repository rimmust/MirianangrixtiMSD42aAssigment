using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float backgroundScrollSpeed = 0.02f;

    Material myMaterial;

    //to move the  offset
    Vector2 offSet;


    // Start is called before the first frame update
    void Start()
    {
        //get space background tiled 
        myMaterial = GetComponent<Renderer>().material;

        //scroll in the y-axis
        offSet = new Vector2(0f, backgroundScrollSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        // move texture material by offset everyframe
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
        
    }
}
