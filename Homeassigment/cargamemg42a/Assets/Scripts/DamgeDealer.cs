using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamgeDealer : MonoBehaviour
{
    [SerializeField] int damage = 1;

   

    public int  GetDamage() //read only acces to dameage object
    {
        return damage;
    }

    //destroy game object
    public void Hit()
    {
        Destroy(gameObject);
    }

}
