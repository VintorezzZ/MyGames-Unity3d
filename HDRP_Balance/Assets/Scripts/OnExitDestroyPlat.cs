using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExitDestroyPlat : MonoBehaviour
{
    private GameObject player;
    //private AudioSource audioSource;
    //public AudioClip audioClip;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //audioClip = audioSource.GetComponent<AudioClip>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject == player)
    //    {

    //        audioSource.PlayOneShot(audioClip);
    //        Debug.Log("playedMusic");
    //    }
            
    //}
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
           
            Destroy(this.gameObject);

        }

    }
}
