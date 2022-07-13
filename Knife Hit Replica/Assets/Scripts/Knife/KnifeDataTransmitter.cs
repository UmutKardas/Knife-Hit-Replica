using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeDataTransmitter : MonoBehaviour
{
    [SerializeField] private KnifeİnputController knifeİnputController;
    [SerializeField] private KnifeShootController knifeShootController;


    public bool isTouch;

    public void setKnifeMovementForce(float value)
    {
        knifeShootController.movementForce = value;
    }



}
