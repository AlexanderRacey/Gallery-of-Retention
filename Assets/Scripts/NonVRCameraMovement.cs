using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonVRCameraMovement : MonoBehaviour
{
    float rotationOnX;
    float mouseSensitivity = 90.0f;
    public Transform player;

    void Start()
    {
        // Hide mouse cursor (prevent player distraction)
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Mouse input
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        float m_X = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;

        // Rotate camera up and down
        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX, -90.0f, 90.0f);
        transform.localEulerAngles = new Vector3(rotationOnX, 0.0f, 0.0f);

        // Rotate left and right
        player.Rotate(Vector3.up * m_X);
    }
}
