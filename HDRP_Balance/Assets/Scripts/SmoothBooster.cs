using UnityEngine;
using System.Collections;

public class SmoothBooster : MonoBehaviour
{
    private Rigidbody rb;
    //bool isFloating = false;
    public float force;
 

    private void Start()
    {
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
        
    }
    
    private void OnTriggerStay(Collider other)
    {
               
        rb.AddForce(Vector3.up * force);
        
    }

    //private void FixedUpdate()
    //{
    //    if (isFloating)
    //    {
    //        rb.AddForce(Vector3.up * force);
    //    }
    //    if (rb.position.y > 4.5)
    //        isFloating = false;
    //}
    //private void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.gameObject.CompareTag("Player"))
    //    {
    //        isFloating = true;
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        isFloating = true;
    //    }

    //}

}