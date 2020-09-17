using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGlassSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
