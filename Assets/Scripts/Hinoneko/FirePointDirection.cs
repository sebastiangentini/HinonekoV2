using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointDirection : MonoBehaviour
{
    public GameObject firePoint;

    float inputHorizontal;

    void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (inputHorizontal > 0)
        {
            FlipRight();
        }
        if (inputHorizontal < 0)
        {
            FlipLeft();
        }
    }

    void FlipLeft()
    {
        firePoint.transform.localEulerAngles = new Vector3(0, 0, 180);
    }

    void FlipRight()
    {
        firePoint.transform.localEulerAngles = new Vector3(0, 0, 0);
    }
}
