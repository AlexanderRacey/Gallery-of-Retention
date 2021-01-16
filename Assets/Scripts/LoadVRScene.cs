using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class LoadVRScene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;

    // Switches to MainScene on button click
    void Start()
    {
        LoadLevel();
        SceneManager.LoadSceneAsync("VRScene");
        SteamVR.Initialize(true);
    }

    /*void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadLevel();
        }
    }*/

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
