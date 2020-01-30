using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	private Rigidbody rb;      //Reference to Rigidbody Component
    public float speed = 5f;
	public float acceleration = 1f;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody> ();
		
        //Random starting direction
        float randX = Random.Range(0, 2) == 0 ? -1 : 1;
        float randY = Random.Range(0, 2) == 0 ? -1 : 1;

        //Set the velocity of the ball, which has a rigidbody
        rb.velocity = new Vector3(speed * randX, speed * randY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
