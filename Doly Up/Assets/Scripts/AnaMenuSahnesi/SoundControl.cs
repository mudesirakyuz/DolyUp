using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    AudioSource seskontrol;
    void Start()
    {
        seskontrol=gameObject.GetComponent<AudioSource>();
    }
    
    public void oynat()
    {
        seskontrol.Play();
    }

    public void durdur()
    {
        seskontrol.Pause();
    }
}
