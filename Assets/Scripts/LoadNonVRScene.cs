using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNonVRScene : MonoBehaviour
{
    // Switches to MainScene on button click
    void Start()
    {
        SceneManager.LoadSceneAsync("NonVRScene");
        Cursor.lockState = CursorLockMode.Locked;
    }
}
