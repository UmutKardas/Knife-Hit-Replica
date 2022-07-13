using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeShootController : MonoBehaviour
{
    [SerializeField] private KnifeDataTransmitter knifeDataTransmitter;
    [SerializeField] private Rigidbody2D knifeRigi;
    public float movementForce;

    void FixedUpdate()
    {
        AddforceKnifeUpMovement();

    }

    private void AddforceKnifeUpMovement()
    {
        if (knifeDataTransmitter.isTouch)
        {
            knifeRigi.AddForce(Vector2.up * movementForce * Time.fixedDeltaTime);
        }
    }
}
