using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur2 : MonoBehaviour
{
    public GameObject stand_Dinosaur;
    public GameObject dive_Dinosaur;
    public GameManager gameManager;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            dive_Dinosaur.SetActive(false);
            stand_Dinosaur.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GameOver();
    }
}
