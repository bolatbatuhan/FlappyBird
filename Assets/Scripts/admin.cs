using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class admin : MonoBehaviour
{
    public GameObject pipe;
    int skor = 0;
    public Text skor_txt;
    void Start()
    {
        InvokeRepeating("add_pipe", 0.0f, 3.0f);

        skor_txt.text = skor.ToString();
    }

    
    void add_pipe()
    {
        GameObject new_pipe = Instantiate(pipe);
    }

    public void add_skor(int deger)
    {
        skor += deger;
        skor_txt.text = skor.ToString();
    }
}
