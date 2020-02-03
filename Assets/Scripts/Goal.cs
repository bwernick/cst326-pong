using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int attackingPlayer; // which player scores into this goal

    public GameManagerScript manager; // this will hold a reference to the game manager script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            manager.GoalScored(attackingPlayer);
        }
    }
}
