using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjToFollow : MonoBehaviour
{
    public Transform objToFollow;
    private Vector3 deltaPos;
    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
    }
}
