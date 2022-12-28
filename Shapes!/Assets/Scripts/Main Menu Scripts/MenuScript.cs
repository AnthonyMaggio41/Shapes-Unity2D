using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public int SceneNum;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
       
    }

    public void QGame()
    {
        Application.Quit();
        Debug.Log("Game quit button yeehaw");
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        MouseFollower.isDead = false;
    }

    public void How2Play()
    {
        SceneManager.LoadScene(5);
    }

    //level selectin'

    public void backButton()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1()
    {
        SceneManager.LoadScene(2);
    }

    public void level2()
    {
        SceneManager.LoadScene(3);
    }

    public void level3()
    {
        SceneManager.LoadScene(4);
    } 


    //absolute bullshit

    public void levelQuit()
    {
       MouseFollower.isDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        SceneManager.LoadScene(SceneNum);
        Debug.Log("level quit button yeehaw");
    }
    
    public void gamewinQ()
    {
        //todo: figure out what isn't needed in here (the function)
        timer.gamewin = false;
        timer.currentTime = timer.startingTime;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
        SceneManager.LoadScene(SceneNum);
        Debug.Log("GameWINQ quit button yeehaw");
    }
}
