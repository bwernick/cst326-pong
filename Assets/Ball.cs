using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Random starting direction
        float randX = Random.Range(0, 2) == 0 ? -1 : 1;
        float randY = Random.Range(0, 2) == 0 ? -1 : 1;

        //Set the velocity of the ball, which has a rigidbody
        GetComponent<Rigidbody>().velocity = new Vector3(speed * randX, speed * randY, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
