using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameScene : MonoBehaviour// bu kod timer olu�turmaya yarar bu timerlar oyundan �nce bekleme sahnelerine konulur
{
    // Start is called before the first frame update
    void Start()
    {
        
    }// bir cisim atan�p onu alma script ekleyip true oldu�unda bu alt k�s�m aktif olabilir

    public float targetTime = 5.0f;
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            timerended();
        }
    }
    void timerended()
    {
        SceneManager.LoadScene("1stwinscene");
    }
}
