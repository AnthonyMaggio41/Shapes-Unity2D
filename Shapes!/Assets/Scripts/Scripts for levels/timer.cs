using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public static float currentTime;
    public static float startingTime;
    public static bool gamewin = false;

    [SerializeField] Text countdownText;
    void Start()
    {
        startingTime = LevelMenus.timercheck;
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime += -1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            // Your Code Here
            Time.timeScale = 0;
            gamewin = true;
            Debug.Log("win");
            

        }
    }
}


