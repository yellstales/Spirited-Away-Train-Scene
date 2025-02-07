using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotationControls : MonoBehaviour
{
    public string ButtonName = "Fire2";
    public float Acceleration = 2f;

    void Update()
    {
        if (Input.GetButton(ButtonName))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.eulerAngles += new Vector3(-mouseY * Acceleration, mouseX * Acceleration, 0);
        }
    }
}
