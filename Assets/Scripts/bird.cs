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
    public float restartHizi = 1f;
    bool gameHasEnded = false;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartHizi);
        }
    }
    void Restart()
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

            rigi.AddForce ( Vector2.up * ziplama_gucu, ForceMode2D.Impulse);

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egilme_hizi);
        }
    }
}
