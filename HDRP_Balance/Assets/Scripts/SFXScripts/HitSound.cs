using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip woodenHit;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.PlayOneShot(woodenHit);
    }

}
