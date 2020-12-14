using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;

    void Start()
    {
        audioSource1.PlayScheduled(AudioSettings.dspTime+20.0);
        double clipLength = audioSource1.clip.samples / audioSource1.clip.frequency;
        audioSource2.PlayScheduled(AudioSettings.dspTime + clipLength+80.0);
        clipLength = clipLength + audioSource2.clip.samples / audioSource2.clip.frequency;
        audioSource3.PlayScheduled(AudioSettings.dspTime + clipLength+ 95.0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
