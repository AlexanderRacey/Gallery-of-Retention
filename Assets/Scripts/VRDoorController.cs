using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

// Open door using button in VR
public class VRDoorController : MonoBehaviour
{
    public GameObject Door;
    public bool vrDoorOpening = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPress(Hand hand)
    {
        OpenDoor();
    }

    // Update is called once per frame
    void Update()
    {
        if(vrDoorOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
    }

    void OpenDoor()
    {
        vrDoorOpening = true;
    }
}
