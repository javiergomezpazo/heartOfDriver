using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioMotor;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playSound(float velocity)
    {
        Debug.Log("PlaySound");
        if(velocity <= 1 && velocity >= -1)
        {
            velocity = 1f;
        }
        audioSource.pitch = velocity/80;
        audioSource.PlayOneShot(audioMotor, 0.8f);
        
    }
   
}
