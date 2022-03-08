using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject hero;
    public GameObject cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position=hero.transform.position+new Vector3(0,5,-10);
        //cam.transform.LookAt(hero.transform);
        
    }
}
