using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCollisionControl : MonoBehaviour
{
    static public bool StarCollisionBoolean=false;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Star")
        {
            StarCollisionBoolean=true;
            Destroy(collision.gameObject);
        } 
        
    }
}
