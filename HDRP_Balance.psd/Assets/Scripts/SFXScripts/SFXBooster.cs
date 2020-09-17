using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXBooster : MonoBehaviour
{
    //public AudioClip boosterSound;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
        }
    }
}
