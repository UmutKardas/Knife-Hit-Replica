using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeÄ°nputController : MonoBehaviour
{
    [SerializeField] KnifeDataTransmitter knifeDataTransmitter;


    void Update()
    {
        HandleTouchInput();
    }
    private void HandleTouchInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knifeDataTransmitter.isTouch = true;

        }
    }
}
