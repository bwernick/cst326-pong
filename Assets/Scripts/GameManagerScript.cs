using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public int playerAScore, playerBScore;
    public Ball gameBall;

    // Start is called before the first frame update
    void Start()
    {
        //playerAScore = 0;
        //playerBScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoalScored(int playerNumber)
    {
        // increase the score for whichever player scored
        if (playerNumber == 1)
        {
            playerAScore++;
            Debug.Log(playerAScore + ":" + playerBScore);
        }
        else if (playerNumber == 2)
        {
            playerBScore++;
            Debug.Log(playerAScore + ":" + playerBScore);
        }

        if (playerAScore == 11)
        {
            GameOver(1);
        }
        else if (playerBScore == 11)
        {
            GameOver(2);
        }
            

    }

    void GameOver(int winner)
    {
        // this is called when a player reaches 3 points 

        // reset the scores
        //playerAScore = 0;
        //playerBScore = 0;
        gameBall.Reset();
    }

}
