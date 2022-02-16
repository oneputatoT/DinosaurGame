using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float timer;
    public float maxtime;

    public GameObject obstacles1;
    public GameObject obstacles2;
    public GameObject obstacles3;
    public GameObject obstacles4;
    public GameObject obstacles5;

    private void Start()
    {
        maxtime = 2;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxtime)
        {
            Create();
            timer = 0;
        }
    }

    private void Create()
    {
        int random = Random.Range(1, 6);  //随机出物体
        if (random == 1) { GameObject newObstacles = Instantiate(obstacles1); }
        if (random == 2) { GameObject newObstacles = Instantiate(obstacles2); }
        if (random == 3) { GameObject newObstacles = Instantiate(obstacles3); }
        if (random == 4) { GameObject newObstacles = Instantiate(obstacles4); }
        if (random == 5) { GameObject newObstacles = Instantiate(obstacles5); }
    }

}
