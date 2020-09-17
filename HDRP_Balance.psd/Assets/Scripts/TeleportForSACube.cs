using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportForSACube : MonoBehaviour
{
    bool isInRange = false;
    private Transform destination;  
    private GameObject SACube;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        destination = GameObject.Find("DestinationForSACube").GetComponent<Transform>();
        SACube = GameObject.Find("SACube");
    }
    void Update()
    {
        transform.Rotate(0f, 1f, 0f); //Монета с каждым кадром будет вращаться
        if (isInRange)
            Teleportt();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == SACube)
        {
            isInRange = true;
            audioSource.Play();
        }
           
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == SACube)
            isInRange = false;
    }

    void Teleportt()
    {
        SACube.transform.position = destination.position;
    }
}
