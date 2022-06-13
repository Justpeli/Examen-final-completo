using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject _isstand;
    public GameObject _iscrouch;
    Rigidbody2D rigidbody;
    private bool _isJumping;
    public GameManager GameManager;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey("space")&&_isJumping==false)
        {
            rigidbody.velocity = new Vector3(0, 20, 0);
            _isJumping = true;
        }
        if (Input.GetKey("down")&&_isJumping==false)
        {
            _iscrouch.SetActive(true);
            _isstand.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        _isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle"))
        {
            GameManager.GameOver();
            
        }

    }
}
