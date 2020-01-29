﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleB : MonoBehaviour
{

    public float speed = 5f;

    public Transform paddle_Top;
    public Transform paddle_Bottom;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.I))
        {
            transform.position = Vector3.MoveTowards(transform.position, paddle_Top.position, step);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position = Vector3.MoveTowards(transform.position, paddle_Bottom.position, step);
        }

    }
}