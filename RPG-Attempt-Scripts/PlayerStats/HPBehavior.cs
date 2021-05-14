using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBehavior : MonoBehaviour
{
    public static int HPValue;
    public int internalHP;
    public Slider HPBar;
    public Image fillImage;


    void Start()
    {
        HPValue = 100;
    }
    void Update()
    {
        internalHP = HPValue;
        HPBar.value = internalHP;
        if(HPBar.value <= HPBar.minValue)       //Completely diable HP Bar when health is zero. Prevents any remnants of HP Bar even if HP = 0.
            fillImage.enabled = false;
        if(HPBar.value > HPBar.minValue && !fillImage.enabled)
            fillImage.enabled = true;
    }
}
