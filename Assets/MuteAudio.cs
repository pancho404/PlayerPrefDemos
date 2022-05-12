using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    int audioState;
    bool on = true;
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = 10;
        //if (PlayerPrefs.HasKey("Audio"))
        //{
        //    audioState = PlayerPrefs.GetInt("Audio");

        //}
        //if (audioState == 0)
        //{
        //    AudioListener.volume = 0;
        //}
        //else
        //{
        //    AudioListener.volume = 1;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        ToggleAudio();
    }

    void ToggleAudio()
    {
        if (Input.GetKey(KeyCode.M) && on)
        {
            AudioListener.volume = 0;
        }
        if (Input.GetKey(KeyCode.M) && !on)
        {
            AudioListener.volume = 10;
        }
    }
}
