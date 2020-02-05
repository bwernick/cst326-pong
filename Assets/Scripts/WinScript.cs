using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{

    public Text textbox;
    public GameManagerScript manager;
    //public AudioClip victory;
    //public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = "";
        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if(manager.playerAScore == 11)
        {
            textbox.text = "Game Over, Player 1 Wins";
            //audio.PlayOneShot(victory, .1f);
        }
        if (manager.playerBScore == 11)
        {
            textbox.text = "Game Over, Player 2 Wins";
            //audio.PlayOneShot(victory, .1f);
        }
    }


}
