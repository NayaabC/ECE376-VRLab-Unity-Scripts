using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXP : MonoBehaviour
{
    public static int currentXP;
    public int internalXP;


    void Update()
    {
        internalXP = currentXP;     //Allows us to monitor XP inside the Inspector Window
    }
}
