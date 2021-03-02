using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRSelectionEnabler : MonoBehaviour
{
    public GameObject vrExperienceButton;

    // Start is called before the first frame update
    void Start()
    {
        if (OpenVR.IsHmdPresent())
        {
            vrExperienceButton.gameObject.SetActive(true);
        }
        else
        {
            vrExperienceButton.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (OpenVR.IsHmdPresent())
        {
            vrExperienceButton.gameObject.SetActive(true);
        }
        else
        {
            vrExperienceButton.gameObject.SetActive(false);
        }
    }
}
