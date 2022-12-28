using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftnRightMove : MonoBehaviour
{
    public float speed = 4.0f;
    [SerializeField]
    private Vector3[] positions;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positions[index], Time.deltaTime * speed);

        if(transform.position == positions[index])
        {
            if(index == positions.Length - 1)
            {
                index = 0;

            }
            else
            {
                index++;
            }
        }
    }

}
