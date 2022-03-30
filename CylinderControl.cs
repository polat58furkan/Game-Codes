using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderControl : MonoBehaviour
{
    public GameObject cylinder;
    public Rigidbody rd;
    private float x,y;
    void Start()
    {
        rd=cylinder.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.touchCount > 0 )
        {
            Touch finger =Input.GetTouch(0);
            /*
            if(finger.phase==TouchPhase.Began)
            {
                Debug.Log("Touching start");
            }
            if(finger.phase==TouchPhase.Stationary)
            {
                Debug.Log("Touching");
            }
            if(finger.phase==TouchPhase.Ended)
            {
                Debug.Log("Touching finished");
            }
            */
            Debug.Log(finger.deltaPosition);
            x=finger.deltaPosition.x;
            y=finger.deltaPosition.y;

            rd.AddForce(new Vector3(x,0,y)*2f);

        }
    }
}
