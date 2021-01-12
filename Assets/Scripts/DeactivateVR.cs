using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

// Start Non-VR version
public class DeactivateVR : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DeactivatorVR("None"));
    }

    public IEnumerator DeactivatorVR(string NOVR)
    {
        XRSettings.LoadDeviceByName(NOVR);
        yield return null;
        XRSettings.enabled = false;
    }
}
