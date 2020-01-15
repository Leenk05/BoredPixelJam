﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Image coolDown;

    public GameObject pause, textTimer;

    private float startTime;

    public float coolTime;


    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
        despausar();
        textTimer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime <= coolTime) {
            coolDown.fillAmount = (Time.time - startTime) / coolTime;
           
        }

        else if (Input.GetKeyDown("p")) {
            pausar();


            //coolDown.fillAmount = 0f;
        }

        else{
            textTimer.SetActive(true);
        }
    }

    void pausar() {
        Time.timeScale = 0f;
        pause.SetActive(true);
    }

    public void despausar() {
        Time.timeScale = 1f;
        pause.SetActive(false);
        //startTime = Time.time;
    }

}
