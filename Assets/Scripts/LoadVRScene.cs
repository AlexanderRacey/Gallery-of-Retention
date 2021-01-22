using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

// Switches to MainScene on button click
public class LoadVRScene : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadSceneAsync("VRScene");
        SteamVR.Initialize(true);
    }

    void Update()
    {

    }
}
