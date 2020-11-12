using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerManager : MonoBehaviour
{
    public int level;
  

    
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
           
            SceneManager.LoadScene(level); 
            
        }
    }

    

    

   
}