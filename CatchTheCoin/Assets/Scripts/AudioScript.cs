using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    //Mute Sound
    public GameObject MusicController;
    public Sprite audioOff;
    public Sprite audioOn;
    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.pause == true)
        {
            MusicController.GetComponent<Image>().sprite = audioOff;
        }
        else
        {
            MusicController.GetComponent<Image>().sprite = audioOn;
        }
    }
    public void SoundControl()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            MusicController.GetComponent<Image>().sprite = audioOn;
        }
        else
        {
            AudioListener.pause = true;
            MusicController.GetComponent<Image>().sprite = audioOff;
        }
    }
}
