using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialDoorOpen : MonoBehaviour
{
    
    public float distance;
    public GameObject actionText;
    public GameObject tutorialGate;
    public GameObject barrier;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
        if(WeaponPickUp.tutSwordStatus == 1) {
            tutorialGate.GetComponent<Animation>().Play("GateWayHugeDoor_Open");
            WeaponPickUp.tutSwordStatus = 0;
            barrier.SetActive(false);
        }
    }


    void OnMouseOver()
    {
        if(distance <= 10) {
            actionText.GetComponent<Text>().text = "Pick Up the Sword First";
            actionText.SetActive(true);
        }
    }

    void OnMouseexit() {
        actionText.SetActive(false);
    }
}
