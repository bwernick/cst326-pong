using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleA : MonoBehaviour
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

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.MoveTowards(transform.position, paddle_Top.position, step);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.MoveTowards(transform.position, paddle_Bottom.position, step);
        }

    }
}
