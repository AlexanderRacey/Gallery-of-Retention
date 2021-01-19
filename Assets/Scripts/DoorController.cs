using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Open door (nonVR)
public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if (Door.transform.position.y > 10.0f)
        {
            doorIsOpening = false;
        }
    }

    // Open door on button click
    void OnMouseDown()
    {
        doorIsOpening = true;
    }
}
