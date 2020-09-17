using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfNextLevel : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
} 
