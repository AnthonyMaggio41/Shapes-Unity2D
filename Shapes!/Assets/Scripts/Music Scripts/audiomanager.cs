using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public static AudioClip Popsound;
    static AudioSource audioSCR;
    
    // Start is called before the first frame update
    void Start()
    {
        Popsound = Resources.Load<AudioClip>("PopSound1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "PopSound1":
                audioSCR.PlayOneShot(Popsound);
                break;
        }
    }
}
