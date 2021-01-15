using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NonVR player mouse movement
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 200.0f;
    public Transform playerBody;

    private float xRotation = 0.0f;

    void Start()
    {
        // Hide and lock cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
