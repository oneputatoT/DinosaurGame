using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Floor Movement
    public float speed;
    public float start;
    public float end;
    
    private void Update()
    {
        transform.position =
            new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= end)
        {
            if (gameObject.tag == "Obstacles")
            {
                Destroy(gameObject);
            }
            transform.position = new Vector2(start, transform.position.y);
        }
    }
}
