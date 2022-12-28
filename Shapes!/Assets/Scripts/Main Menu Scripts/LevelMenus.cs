using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenus : MonoBehaviour
{
    public GameObject deathMenuUI;
    public GameObject winMenuUI;


    public float inputSTime = 0f;
    public static float timercheck = 0f;

    // Update is called once per frame
    void Start()
    {
        timercheck = inputSTime;
    }

    void Update()
    {
        if(MouseFollower.isDead == true)
        {
            DeathMenu();
        }

        if (timer.gamewin == true)
        {
            WinPause();
            Debug.Log("GameWin Timer");
        }
        else if (timer.gamewin == false)
        {
            WinPause2();
            Debug.Log("GameWin2 Timer");
        }
    }


    void DeathMenu()
    {
        deathMenuUI.SetActive(true);
    }

    void WinPause()
    {
        winMenuUI.SetActive(true);
    }

    void WinPause2()
    {
        winMenuUI.SetActive(false);
    }
}
