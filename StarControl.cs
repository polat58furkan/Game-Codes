using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControl : MonoBehaviour
{
    public GameObject StarInstantiate;
    GameObject Clone;
    public float f,p;
    private bool starboolean=true;
    static public bool ScoreBoolean=false;
    void Update()
    {
        if(starboolean==true)
        {
            starboolean=false;
            for(int i=0 ;i<10;i++)
            {
                f=Random.Range(-10,10);
                p=Random.Range(10,800);
                Clone = Instantiate(StarInstantiate,new Vector3(f,p,-0.5f),Quaternion.Euler(0,0,0));  
            }
        }

        if(HeroCollisionControl.StarCollisionBoolean==true)
        {
            HeroCollisionControl.StarCollisionBoolean=false;
            ScoreBoolean=true;

        }
    }
}
