using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeepScript : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
        audio.playOnAwake = false;
        audio.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void OnCollisionEnter(Collision col)  //Plays Sound Whenever collision detected
    {
        audio.Play();
    }
}
