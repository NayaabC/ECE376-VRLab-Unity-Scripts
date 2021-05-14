using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour
{
    public int damageAmount = 5;    //Set amount of damage for now
    public float targetDistance;    //Distance between player and enemy
    public float allowedRange = 3.7f;


    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            RaycastHit hitInfo;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo))
            {
                targetDistance = hitInfo.distance;
                if(targetDistance <= allowedRange)
                {
                    hitInfo.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
