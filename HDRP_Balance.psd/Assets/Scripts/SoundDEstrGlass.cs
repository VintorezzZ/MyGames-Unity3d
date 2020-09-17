using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDEstrGlass : MonoBehaviour
{
    public AudioClip glass;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("VanishObj"))
        {
            audioSource.PlayOneShot(glass);
        }

    }
}
