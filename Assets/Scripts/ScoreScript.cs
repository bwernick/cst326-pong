using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text textbox;
    public GameManagerScript manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int A = manager.playerAScore;
        int B = manager.playerBScore;
        textbox.text = A + " : " + B;
    }
}
