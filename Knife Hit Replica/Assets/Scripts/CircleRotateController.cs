using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotateController : MonoBehaviour
{
    [SerializeField][Range(150, 500)] private float rotateSpeed;


    void Update()
    {
        SetCircleRotateSpeed();

    }
    private void SetCircleRotateSpeed()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
