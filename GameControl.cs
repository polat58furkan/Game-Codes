using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject hero;

    void Update()
    {
        if(hero.transform.position.y<-5)
        {
            SceneManager.LoadScene(1);
        }
        if(hero.transform.position.y>=1000)
        {
            SceneManager.LoadScene(4);
        }
        if(hero.transform.position.x<-17 || hero.transform.position.x>17)
        {
            SceneManager.LoadScene(4);
        }
    }
}
