using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public Transform CameraAxisTransform;
    public float MinAngle;
    public float MaxAngle;
    public float RotationSpeed;

    void Update()
    {
        float newAngleY = transform.localEulerAngles.y + RotationSpeed * Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(0, newAngleY, 0);

        float newAngleX = CameraAxisTransform.localEulerAngles.x - RotationSpeed * Input.GetAxis("Mouse Y");
        if (newAngleX > 180)
        {
            newAngleX -= 360;
        }
        newAngleX = Mathf.Clamp(newAngleX, MinAngle, MaxAngle);
        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}