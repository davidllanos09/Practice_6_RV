using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public float x;
    public float y;
    public bool gyroEnabled = true;
    float sensitivity = 50f;
    Gyroscope gyro;

    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroEnabled)
        {
            x = Input.gyro.rotationRate.x;
            y = Input.gyro.rotationRate.y;
            gyro.enabled = true;
            float xFiltered = FilerGyroValue(x);
            transform.RotateAround(transform.position,
                transform.right, -xFiltered * sensitivity * Time.deltaTime);
            float yFiltered = FilerGyroValue(y);
            transform.RotateAround(transform.position,
                transform.up, -yFiltered * sensitivity * Time.deltaTime);
        }

    }

    float FilerGyroValue(float axis)
    {
        if (axis < -0.1f || axis > 0.1f)
            return axis;
        else
            return 0;
    }
}
