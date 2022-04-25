using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject hero;
    public GameObject cam;
    public float Speed=0.05;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position=hero.transform.position+new Vector3(0,5,-10);
        //cam.transform.LookAt(hero.transform);
        
        // Yumuşak bir şekilde takip için
        //cam.transform.position = Vector3.Slerp(cam.transform.position, hero.transform.position,Speed);
        
    }
}
