using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed = 20f;

	public bool isPaddleA;
	
    public Transform paddle_Top;
    public Transform paddle_Bottom;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        if(isPaddleA){
			if (Input.GetKey(KeyCode.W))
			{
				transform.position = Vector3.MoveTowards(transform.position, paddle_Top.position, step);
			}
			if (Input.GetKey(KeyCode.S))
			{
				transform.position = Vector3.MoveTowards(transform.position, paddle_Bottom.position, step);
			}
		}else{
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
}
