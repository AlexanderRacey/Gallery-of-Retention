using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;
using TMPro;

// Open door using button in VR
public class VRDoorController : MonoBehaviour
{
    public GameObject Door; 
    public bool vrDoorOpening = false;
    private bool timerCounting = false;

    public Animator transition;
    public float transitionTime = 1.0f;

    public TextMeshPro textMesh;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        //time = 21.0f;
        time = 601.0f;
        timerCounting = false;
    }

    public void OnPress(Hand hand)
    {
        OpenDoor();
        TimerStart();
    }

    // Update is called once per frame
    void Update()
    {
        if(vrDoorOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }

        if (timerCounting == true)
        {
            string minSec = string.Format("{0}:{1:00}", (int)time / 60, (int)time % 60);
            textMesh.text = minSec;
            time -= Time.deltaTime;

            if (time < 0.0f)
            {
                LoadLevel();
                SceneManager.LoadSceneAsync("VRClosingScene");
            }
        }
    }

    void OpenDoor()
    {
        vrDoorOpening = true;
    }

    void TimerStart()
    {
        timerCounting = true;
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
