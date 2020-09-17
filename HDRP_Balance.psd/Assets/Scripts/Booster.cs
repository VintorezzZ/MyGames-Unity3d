using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{

    public float force;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody playerRb;
        if(other.CompareTag("Player"))
        {
            audioSource.Play();
            Debug.Log("PlayedSFXBosster");
            playerRb = other.GetComponent<Rigidbody>();
            playerRb.AddForce(transform.up * force);
        }
        
    }
}
