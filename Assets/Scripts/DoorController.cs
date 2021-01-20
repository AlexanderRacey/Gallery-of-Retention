using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Open door (nonVR)
public class DoorController : MonoBehaviour
{
    public Animator buttonAnimation;

    public GameObject Door;
    public bool doorIsOpening;

    public Transform player;
    public Transform button;
    public float interactionDistance = 3.0f;

    public GameObject mouseClickPrompt;

    // Assign animation component
    void Start()
    {
        buttonAnimation.GetComponent<Animator>();
        mouseClickPrompt.SetActive(false);
    }

    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(button.position, player.position);

        if (doorIsOpening == false)
        {
            if (distanceFromPlayer < interactionDistance)
            {
                mouseClickPrompt.SetActive(true);
            }
            else
            {
                mouseClickPrompt.SetActive(false);
            }
        }

        if (doorIsOpening == true)
        {
            buttonAnimation.Play("DoorButtonPush");
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
        float distanceFromPlayer = Vector3.Distance(button.position, player.position);

        if (distanceFromPlayer < interactionDistance)
        {
            doorIsOpening = true;
            mouseClickPrompt.SetActive(false);
        }
    }
}