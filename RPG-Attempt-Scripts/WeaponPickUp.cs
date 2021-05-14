using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPickUp : MonoBehaviour
{
    public static int tutSwordStatus;
    public int InternalOpen;
    public float distance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject weaponAnimated;
    public GameObject weaponInHand;
    public GameObject Player;



    // Update is called once per frame
    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
        InternalOpen = tutSwordStatus;
    }

    void OnMouseOver()
    {
        if(distance <= 5)
        {
            actionText.GetComponent<Text>().text = "Pick Up Sword";
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if(Input.GetButtonDown("Action"))
        {
            if(distance <= 5)
            {
                weaponAnimated.SetActive(false);
                weaponInHand.SetActive(true);
                actionText.SetActive(false);
                actionDisplay.SetActive(false);
                tutSwordStatus = 1;
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
    


}
