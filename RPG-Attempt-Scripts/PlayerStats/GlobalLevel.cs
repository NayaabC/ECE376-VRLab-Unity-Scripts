using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int currentLevel = 1;
    public int internalLevel;


    void Update()
    {
        internalLevel = currentLevel;     //Allows us to monitor User's level inside the Inspector Window
    }
}
