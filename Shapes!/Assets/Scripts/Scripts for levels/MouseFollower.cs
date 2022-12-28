using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseFollower : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;


    //bool for death
    public static bool isDead = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        //back to main level menu

        if (Input.GetButtonDown("Cancel"))
        {
            Debug.Log("Back");
            SceneManager.LoadScene(1);
        }
        if (isDead == false)
        {
            Time.timeScale = 1;


        }

    }

    //how to kill the player...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dead");
        isDead = true;
        PauseGame();
        Destroy(gameObject);
    }

    void PauseGame()
    {
        Debug.Log("Pause");
        Time.timeScale = 0;
    }
}

