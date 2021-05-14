using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distanceFromTarget;
    public float target;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo))    
        {
            target = hitInfo.distance;
            distanceFromTarget = target;
        }
    }
}
