using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    public GameManagerScript manager;
    private bool playSound, maxScore;


    public AudioClip clip;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        playSound = true;
        maxScore = false;
        audio.playOnAwake = false;
        audio.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        if ((manager.playerAScore == 11) || (manager.playerBScore == 11))
        {
            playSound = false;
            maxScore = true;
        }

        if (!playSound && maxScore)
        {
            audio.PlayOneShot(clip);
            playSound = true;
        }
    }
}
