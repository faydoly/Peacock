using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPandaLook : MonoBehaviour
{
    public float mouseSensitivity = 120f;
    public Transform redPanda;
    private float xRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.EulerRotation(xRotation, 0f, 0f);
        redPanda.Rotate(Vector3.up * mouseX);
    }
}
