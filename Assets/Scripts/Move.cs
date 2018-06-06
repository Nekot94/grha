using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.5f;
    public float distance = 8;

    void Start()
    {
        Debug.Log(speed);
    }

    void Update()
    {
        if (transform.position.x >= distance || transform.position.x <= -distance)
        {
            speed = -speed;
        }

        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}

