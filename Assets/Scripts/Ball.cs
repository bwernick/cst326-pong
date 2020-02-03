using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	private Rigidbody rb;      //Reference to Rigidbody Component
    //private float base_speed = 5f;
    public float speed = 5f;
	public float acceleration = 5f;

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
        Vector3 normalizedVel = rb.velocity.normalized;
        rb.AddForce(normalizedVel * acceleration);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "goalA")
        {
            transform.position = new Vector3(0, 0, 1);
            float randY = Random.Range(0, 2) == 0 ? -1 : 1;
            float temp_x = -1;
            rb.velocity = new Vector3(speed * temp_x, speed * randY, 0f);
        }

        if (col.gameObject.name == "goalB")
        {
            transform.position = new Vector3(0, 0, 1);
            float randY = Random.Range(0, 2) == 0 ? -1 : 1;
            float temp_x = 1;
            rb.velocity = new Vector3(speed * temp_x, speed * randY, 0f);
        }
    }

    float BallHitPaddleWhere(Vector3 ball, Vector3 paddle, float paddleHeight)
    {
        return (ball.y - paddle.y) / paddleHeight;
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(0, 0, 1);
        //Start();
    }
}
