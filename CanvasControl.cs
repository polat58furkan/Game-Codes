using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    public Slider slider;
    public GameObject hero;

    public Text ScoreText;

    static public float score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value=hero.transform.position.y;
        if(StarControl.ScoreBoolean==true)
        {
            StarControl.ScoreBoolean=false;
            score+=10;
            ScoreText.text="Score = "+ score.ToString();
        }
    }
}
