using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject sword;
    public int swordStatus;

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && swordStatus == 0) {
            StartCoroutine(swingSwordFunc());
        }
    }

    IEnumerator swingSwordFunc() {
        swordStatus = 1;
        sword.GetComponent<Animation>().Play("SwordAnim");
        swordStatus = 2;                                    //Playing the animation
        yield return new WaitForSeconds(0.01f);              //Waiting for 60frames or 1 second
        swordStatus = 0;
    }
}
