using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    //color text numbers dict for calling on score textbox.
    string[] scoreText = new string[13]{"<color=white>0</color>", "<color=orange>1</color>", "<color=red>2</color>", "<color=purple>3</color>", 
                                        "<color=aqua>4</color>", "<color=lightblue>5</color>", "<color=fuchsia>6</color>", "<color=lime>7</color>",
                                        "<color=olive>8</color>", "<color=#03fc77ff>9</color>", "<color=#fc0398ff>10</color>", "<color=#b8fcfbff>11</color>", 
                                        "<color=white>12</color>"};
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

        //C# can handle markup in text
        textbox.text = scoreText[A] + " : " + scoreText[B];
    }
}
