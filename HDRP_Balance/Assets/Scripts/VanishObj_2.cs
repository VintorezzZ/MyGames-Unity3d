using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishObj_2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(TimeToWait());
        }

    }

    IEnumerator TimeToWait()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
