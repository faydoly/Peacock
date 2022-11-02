using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPandaLook : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 450f;
    private float cameraVerticalRotaion = 0f;

    private bool lockedCursor = true;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        cameraVerticalRotaion -= inputY;
        cameraVerticalRotaion = Mathf.Clamp(cameraVerticalRotaion, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotaion;

        player.Rotate(Vector3.up * inputX);
    }
}
