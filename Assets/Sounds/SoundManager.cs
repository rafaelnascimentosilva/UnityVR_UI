using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    AudioSource audioSource;
    public AudioClip _somAmbiente;
    public AudioClip _radioMusic;
    public AudioClip _caminhando;
    public AudioClip _tampando;

    void Start()
    {
        //audioSource = this.gameObject.AddComponent<AudioSource>();
       
        audioSource = GetComponent<AudioSource>();
    }

    public void ExecutaSom()
    {
        audioSource.clip = _somAmbiente;
        audioSource.Play();
    }
}
