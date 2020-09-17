using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallSound : MonoBehaviour
{
    private float speed;
    private Rigidbody rigidBody;
    private AudioSource ballSoundSource;
    public AudioClip woodenHit;
    public AudioClip rollingBall;
    public float k;
    public float c;
 
    void Start()
    {
        rigidBody = GetComponent< Rigidbody > ();
        ballSoundSource = GetComponent< AudioSource > ();
    }

    void FixedUpdate()
    {
        speed = rigidBody.velocity.magnitude;       
        ballSoundSource.pitch = speed * k;
        ballSoundSource.volume = speed * c;
    }
    void OnCollisionStay(Collision collision)
    {
        ballSoundSource.clip = rollingBall;
        if (ballSoundSource.isPlaying == false && speed >= 0 && collision.gameObject.CompareTag("Ground"))
        {
            ballSoundSource.Play();
        }
        else if (ballSoundSource.isPlaying == true && speed < 0 && collision.gameObject.CompareTag("Ground"))
        {
            ballSoundSource.Pause();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        ballSoundSource.clip = rollingBall;
        if (ballSoundSource.isPlaying == true && collision.gameObject.CompareTag("Ground"))
        {
            ballSoundSource.Pause();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //ballSoundSource.clip = woodenHit;
        //ballSoundSource.pitch = Random.Range(0.8f, 1.2f);
        ballSoundSource.PlayOneShot(woodenHit);
    }

}
