using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipe : MonoBehaviour
{
    admin adm;
    
    void Start()
    {
        float rast = Random.Range(-2.36f, -3.60f);
        transform.position = new Vector3(4f , rast, transform.position.z);

        adm  = GameObject.Find("admin").GetComponent<admin>();
    }

    
    void Update()
    {
        if ( transform.position.x <= -4)
        {
            adm.add_skor(10);
            Destroy(gameObject);
            
        }
        transform.Translate(-1.3f*Time.deltaTime,0,0);

        
    }
}
