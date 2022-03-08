using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    
    public GameObject GroundInstantiate;
    public float x=0;
    public float y=0;

    public int randomInt;
    void Start()
    {
        for(int i =1 ; i<100;i++)
        {
            x=Random.Range(-10,10);
            y+=10;
            GroundInstantiate.GetComponent<Transform>().localScale=new Vector3(Random.Range(5,15),1,1);
            GroundInstantiate = Instantiate(GroundInstantiate,new Vector3(x,y,0),Quaternion.Euler(0,0,0));
            
        }        
    }
}
