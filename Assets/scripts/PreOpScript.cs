using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreOpScript : MonoBehaviour
{
    public AudioSource audioNurse;
    public AudioSource audioAnastisist;
    public AudioSource audioSurgeon;
    public AudioSource audioBeginOperation;
    public AudioSource duringOp2;
    public AudioSource duringOp3;


    void Start()
    {
        audioNurse.PlayScheduled(AudioSettings.dspTime+ 15.0);
        double clipLength = audioNurse.clip.samples / audioNurse.clip.frequency;

        audioAnastisist.PlayScheduled(AudioSettings.dspTime + clipLength+ 47.0);
        clipLength = clipLength + audioAnastisist.clip.samples / audioAnastisist.clip.frequency;

        audioSurgeon.PlayScheduled(AudioSettings.dspTime + clipLength+ 50.0);
        clipLength = clipLength + audioSurgeon.clip.samples / audioSurgeon.clip.frequency;

        audioBeginOperation.PlayScheduled(AudioSettings.dspTime + clipLength+ 65.0);
        clipLength = clipLength + audioBeginOperation.clip.samples / audioBeginOperation.clip.frequency;

        duringOp2.PlayScheduled(AudioSettings.dspTime + clipLength+ 95.0);
        clipLength = clipLength + duringOp2.clip.samples / duringOp2.clip.frequency;

        duringOp3.PlayScheduled(AudioSettings.dspTime + clipLength+ 115.0);
        clipLength = clipLength + duringOp3.clip.samples / duringOp3.clip.frequency;

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
