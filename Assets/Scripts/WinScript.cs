using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{

    public Text textbox;
    public GameManagerScript manager;

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = "";
    }

    // Update is called once per frame
    void Update()
    {
       if(manager.playerAScore == 11)
        {
            textbox.text = "Game Over, Player 1 Wins";
        }
        if (manager.playerBScore == 11)
        {
            textbox.text = "Game Over, Player 2 Wins";
        }
    }


}
