using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundControl : MonoBehaviour
{
    public GameObject BgInstantiate;
    public Material material;

    public float y=0;
    
    void Start()
    {
        
        for(int i =1 ; i<12;i++)
        {   

            Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
            material.color=newColor;
            BgInstantiate = Instantiate(BgInstantiate,new Vector3(0,y,2),Quaternion.Euler(-90,0,0));
            y+=100;   
        } 
        
    }

}
