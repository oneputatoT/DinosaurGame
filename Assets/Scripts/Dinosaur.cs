using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    public GameObject stand_Dinosaur;
    public GameObject dive_Dinosaur;
    public GameManager gameManager;
    AudioSource jumpSound;

    Rigidbody2D rigidbody2D;
    public float Speed=20;
    bool isJumping;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();   
        isJumping = false;
        jumpSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false) 
        {
            rigidbody2D.velocity = new Vector2(0, Speed);
            isJumping = true;
            jumpSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.C) && isJumping == false)
        {
            stand_Dinosaur.SetActive(false);
            dive_Dinosaur.SetActive(true);
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GameOver();
    }

}
