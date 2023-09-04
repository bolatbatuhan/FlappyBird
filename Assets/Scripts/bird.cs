using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bird : MonoBehaviour
{
    Rigidbody2D rigi;
    public float ziplama_gucu;
    public float egilme_hizi;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }



    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi.velocity = Vector2.zero;

            rigi.velocity = Vector2.up.normalized *Time.deltaTime * ziplama_gucu ;

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egilme_hizi);
        }
    }
}
