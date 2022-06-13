using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public GameObject _isstand;
    public GameObject _iscrouch;
    public GameManager GameManager;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyUp("down"))
        {
            _iscrouch.SetActive(false);
            _isstand.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Obstacle")
        {
            GameManager.GameOver();
            
        }

    }
}
