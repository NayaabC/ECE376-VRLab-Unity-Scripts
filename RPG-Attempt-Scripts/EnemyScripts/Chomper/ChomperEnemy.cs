using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperEnemy : MonoBehaviour
{
    
    public int enemyHealth = 10;         //Amount of Health Points (HP) on Enemy
    public GameObject chomper;
    public int chomperStatus;
    public int baseXP = 10;
    public int calculatedXP;
    public ChomperAI ChomperAIScript;
    public static int globalChomper;

    void Start()
    {
        ChomperAIScript = GameObject.Find("Chomper").GetComponent<ChomperAI>();
    }

    void DeductPoints(int damageAmount) {
        enemyHealth -= damageAmount;
    }

    void Update()
    {
        globalChomper = chomperStatus;
        if(enemyHealth <= 0) {
            if(chomperStatus == 0)
                StartCoroutine(deathChomper());
        }
    }

    IEnumerator deathChomper()
    {
        ChomperAIScript.enabled = false;
        chomperStatus = 8;                                             //Status 8 = dead
        calculatedXP = baseXP * GlobalLevel.currentLevel;
        GlobalXP.currentXP += calculatedXP;                           //Needs to be changed according to level.
        yield return new WaitForSeconds(0.5f);
        chomper.GetComponent<Animation>().Play("ChomperHit4");
    }
}
