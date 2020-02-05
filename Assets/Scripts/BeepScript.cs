using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeepScript : MonoBehaviour
{
    public AudioClip paddleBounce;
    public AudioClip goal;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void OnCollisionEnter(Collision col)  //Plays Sound Whenever collision detected
    {
        if ((col.gameObject.name == "paddleA") || (col.gameObject.name == "paddleB"))
        {
            audio.PlayOneShot(paddleBounce, 1f);
        }

        if ((col.gameObject.name == "goalA") || (col.gameObject.name == "goalB"))
        {
            audio.PlayOneShot(goal, 1f);
        }
    }
}
