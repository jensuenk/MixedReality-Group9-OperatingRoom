﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(105.0f);
        StopAudio();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator StopAudio(){
        yield return new WaitForSeconds(217f);
        myAudio.Stop();
    }
}
