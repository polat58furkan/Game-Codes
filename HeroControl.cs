using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroControl : MonoBehaviour
{
    public GameObject hero;
    private Rigidbody rd;
    float timer=0;
    public float Horinput;
    public float speed=500f;
    public AudioSource source;
    
    void Start()  
    {
        rd=hero.GetComponent<Rigidbody>();
    }

    void Update()
    {
        timer+= Time.deltaTime;
        
        if(Input.GetButtonDown("Jump") && (timer-1.5f>0))
        {
            timer=0;
            source.Play();
            rd.AddForce(Vector3.up*15f,ForceMode.Impulse);
        }
        
        Horinput=Input.GetAxis("Horizontal");
        //hero.transform.Translate(Vector3.right*Time.deltaTime*5f*Horinput);
        rd.AddForce(Vector3.right*Time.deltaTime*speed*Horinput);
        
    }



}
