using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

// Main timer
public class TimerUpdater : MonoBehaviour
{
    public GameObject doorButton;

    private TextMeshPro textMesh;
    private float time;
    private bool timerCounting;

    void Start()
    {
        // Total time displayed in seconds
        textMesh = GetComponent<TextMeshPro>();
        time = 20.0f;
        //time = 601.0f;
        timerCounting = false;
    }

    // Start timer when door opens
    void Update()
    {
        if (doorButton.GetComponent<DoorController>().doorIsOpening == true)
        {
            timerCounting = true;
        }

        if (timerCounting)
        {
            string minSec = string.Format("{0}:{1:00}", (int)time / 60, (int)time % 60);
            textMesh.text = minSec;
            time -= Time.deltaTime;

            if (time < 0.0f)
            {
                SceneManager.LoadSceneAsync("ClosingScene");
            }
        }
    }
}
