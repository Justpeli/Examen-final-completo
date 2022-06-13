using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    private Text scoretext;
    private float timer;
    private float Maxtime;
    
    void Start()
    {
        score = 0;
        scoretext = GetComponent<Text>();
        Maxtime = .1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= Maxtime)
        {
            score++;
            scoretext.text = score.ToString(("00000"));
            timer = 0;
        }
        
    }
}
