using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // axis things
    public float xa, ya, za;
    public int numofspawn;
    public float timer = 0;
    public float spawnerTime = 0;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        //Instantiate(myPrefab, new Vector3(xa, ya, za), Quaternion.identity);
          
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnerTime)
        {
            for (int i = 0; i < numofspawn; i++)
            {
                
                Instantiate(myPrefab, new Vector3(xa, ya, za), Quaternion.identity);
                
            }

            //audiomanager.PlaySound("PopSound1");
            timer = 0;
        }

    }
}
