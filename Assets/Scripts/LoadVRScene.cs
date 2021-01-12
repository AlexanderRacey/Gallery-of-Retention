using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class LoadVRScene : MonoBehaviour
{
    // Switches to MainScene on button click
    void Start()
    {
        SceneManager.LoadSceneAsync("VRScene");
        SteamVR.Initialize(true);
    }
}
