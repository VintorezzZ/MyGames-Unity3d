using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DethCollider : MonoBehaviour
{
    public Transform destination;
    public GameObject player;
    public int level;
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.position = destination.position;
            SceneManager.LoadScene(level);
        }
                   
    }

    

}
