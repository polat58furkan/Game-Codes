using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsControl : MonoBehaviour
{
    public GameObject hero;
    private Rigidbody rd;
    float timer=0;
    public float speed=10000f;
    public AudioSource source;

    bool jumpboolean=false;
    void Start()
    {
        rd=hero.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
        if((timer-1.5f>0) && jumpboolean==true )
        {
            timer=0;
            jumpboolean=false;
            source.Play();
            rd.AddForce(Vector3.up*15f,ForceMode.Impulse);
        }
    }

    public void Right()
    {
        rd.AddForce(Vector3.right*Time.deltaTime*speed);
    }
    public void Left()
    {
        rd.AddForce(Vector3.right*Time.deltaTime*speed*-1f);
    }
    public void Jump()
    {
        jumpboolean=true;
    }
}
