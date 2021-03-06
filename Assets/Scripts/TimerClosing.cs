﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Timer before application closes
public class TimerClosing : MonoBehaviour
{
    private TextMeshProUGUI countdownTextMesh;
    private float time;

    void Start()
    {
        countdownTextMesh = GetComponent<TextMeshProUGUI>();
        time = 21.0f;
    }

    void Update()
    {
        string coundownTime = string.Format("{0}:{1:00}", (int)time / 60, (int)time % 60);
        countdownTextMesh.text = coundownTime; 
        time -= Time.deltaTime;

        // Quit application when time is 0
        if (time < 0.0f)
        {
            Application.Quit();
        }
    }
}
