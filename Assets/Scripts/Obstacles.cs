using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float maxTime;
    public float timer;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    private int choseObstacle;
    void Start()
    {
        maxTime = 1f;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle()
    {
        choseObstacle = Random.Range(1, 8);
        if(choseObstacle==1){GameObject newObstacle = Instantiate(obstacle1);}
        if(choseObstacle==2){GameObject newObstacle = Instantiate(obstacle2);}
        if(choseObstacle==3){GameObject newObstacle = Instantiate(obstacle3);}
        if(choseObstacle==4){GameObject newObstacle = Instantiate(obstacle4);}
        if(choseObstacle==5){GameObject newObstacle = Instantiate(obstacle5);}
        if(choseObstacle==6){GameObject newObstacle = Instantiate(obstacle6);}
        
       
    }
}
