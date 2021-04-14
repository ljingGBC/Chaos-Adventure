using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//import Audio
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        Debug.Log(volume);//show change in console
        audioMixer.SetFloat("mainVolume", volume);//"mainVolume" must match the name of Exposed Parameters in Audion Mixer
    }
}
