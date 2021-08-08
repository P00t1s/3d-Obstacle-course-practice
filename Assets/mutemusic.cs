using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutemusic : MonoBehaviour
{
    //Initialize variables
    private AudioSource music;
    public bool ismute = false;
    // Start is called before the first frame update
    void Start()
    {
        //Get the audiosource
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check for the M key being pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            //Check the status of the ismute bool
            if (ismute == false)
            {
                //Mute and set ismute to true
                music.mute = true;
                ismute = true;
            }
            else if (ismute == true)
            {
                //Unmute and set ismute to false
                music.mute = false;
                ismute = false;
            }
        }
    }
}
