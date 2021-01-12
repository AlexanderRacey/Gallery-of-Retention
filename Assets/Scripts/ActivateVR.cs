using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

// Start VR version
public class ActivateVR : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(ActivatorVR("OpenVR"));
    }

    public IEnumerator ActivatorVR(string YESVR)
    {
        XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        XRSettings.enabled = true;
    }
}
