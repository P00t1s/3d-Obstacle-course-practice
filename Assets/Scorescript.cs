using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorescript : MonoBehaviour
{
    //Initialize variables
    public static int score;
    public Text scoretext;
    public static void updateScore()
    {
        //add to the score variable when updateScore is called
        score++;
    }
    public static void resetscore()
    {
        score = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate() {
        //Update the score text at the end of the frame
        scoretext.text = "Score: "+score;
    }
}
