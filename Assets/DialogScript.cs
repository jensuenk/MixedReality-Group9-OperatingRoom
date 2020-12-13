using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
   public AudioSource audioSource1;
    public AudioSource audioSource2;

    void Start()
    {
        audioSource1.PlayScheduled(AudioSettings.dspTime+10.0);
        double clipLength = audioSource1.clip.samples / audioSource1.clip.frequency;
        audioSource2.PlayScheduled(AudioSettings.dspTime + clipLength+13.0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
