using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherObject) //go on laser prefab,add component and capsule collider 2D
    {
        Destroy(otherObject.gameObject);

    }
}
