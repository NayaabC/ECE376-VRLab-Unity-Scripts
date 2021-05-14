using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperAI : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject chomper;
    public float targetDistance;            //How far from the player
    public float allowedRange = 20;              //Allowed range to attack
    public float chomperSpeed;
    public int canAttack;                   //0 = idle, 1 = attack
    public RaycastHit attack;               
    public int dealingDamage;

    
    void Update()
    {
        transform.LookAt(Player.transform);   

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out attack))
        {
            targetDistance = attack.distance;
            if(targetDistance <= allowedRange)
            {
                chomperSpeed = 0.02f;
                if(canAttack == 0)
                {
                    chomper.GetComponent<Animation>().Play("ChomperWalkForward");
                    transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, chomperSpeed);
                }
            } else {
                chomperSpeed = 0;
                chomper.GetComponent<Animation>().Play("ChomperIdle");
            }
        }

        if(canAttack == 1)
        {
            if(dealingDamage == 0)
            {
                chomperSpeed = 0;
                chomper.GetComponent<Animation>().Play("ChomperAttack");
                StartCoroutine(TakingDamage());
            }
            
        }
    }

    void OnTriggerEnter()
    {
        canAttack = 1;
    }

    void OnTriggerExit()
    {
        canAttack = 0;
    }

    IEnumerator TakingDamage()
    {
        dealingDamage = 2;
        yield return new WaitForSeconds(1.0f);      //Time for damage to be dealt to the player
        if(ChomperEnemy.globalChomper != 8)
        {
            if(HPBehavior.HPValue < 30)
                HPBehavior.HPValue = 0;
            else HPBehavior.HPValue -= 30;
        }
        yield return new WaitForSeconds(0.4f);
        dealingDamage = 0;
    }
}
