using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Grabbing the different audio sources
    public AudioSource AUD1;
    public AudioSource AUD2;
    public AudioSource Music; // no need for this yet its just here for later.


    public List<AudioClip> clips = new List<AudioClip>();
    // Update is called once per frame

    public void Playsound1()
    {
        //play the audio file from the list
        //if the first audio file is preoccupied try another that is not playing
        //more can be added on if need be 
        //More functions can be added if need be. 

        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[0];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[0];
            AUD1.Play();
        }
    }
    public void Playsound2()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[1];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[1];
            AUD1.Play();
        }
    }
    public void Playsound3()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[2];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[2];
            AUD1.Play();
        }
    }
   public void Playsound4()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[3];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[3];
            AUD1.Play();
        }
    }
    public void Playsound5()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[4];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[4];
            AUD1.Play();
        }
    }
    public void Playsound6()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[5];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[5];
            AUD1.Play();
        }
    }
    public void Playsound7()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[6];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[6];
            AUD1.Play();
        }
    }
    public void Playsound8()
    {
        if (AUD1.isPlaying)
        {
            AUD2.clip = clips[7];
            AUD2.Play();
        }
        else
        {
            AUD1.clip = clips[7];
            AUD1.Play();
        }
    }
    void Update()
    {
        
    }
}
