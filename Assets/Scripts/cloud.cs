using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // -4.00 basa al 4.00  y 4, 0.4

    void Start()
    {
        
    }

    // 
    void Update()
    {
        if(transform.position.x <= -4.0f)
        {
            float high = Random.Range(0.4f, 4f);

            transform.position = new Vector3(4, high , transform.position.z);
        }

        transform.Translate(-1.0f*Time.deltaTime,0,0);
    }
}
