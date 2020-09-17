using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject SAPlat;
    public GameObject SACube;
    private void Start()
    {
        SAPlat = GameObject.Find("SetActivePlat");
        SACube = GameObject.Find("SACube");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == SACube)
          SAPlat.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == SACube)
            SAPlat.SetActive(true);
    }
}
