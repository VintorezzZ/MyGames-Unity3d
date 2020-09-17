using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishingObj : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(TimeToWait());
        }
        
    }

    IEnumerator TimeToWait()
    {
        if (GameObject.FindWithTag("VanishObj"))
        {
            yield return new WaitForSeconds(0.1f);
            Destroy(this.gameObject);
        }
        else
        {
            yield return new WaitForSeconds(1);
            Destroy(this.gameObject);
        }
       
    }
}


