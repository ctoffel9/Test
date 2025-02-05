﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    //Level 1
    public bool level1;
    private dropScript DScript;
    public codeBarScripts cbScripts;
    public GameObject[] pakYudha;
    public GameObject[] teknisi;
    public GameObject[] keyBoard;
    

    //Level 2
    public bool level2;
    public GameObject[] Lights;
    public GameObject doorWitchCode;
    public bool RightCode;
    public bool end;
    public GameObject EndTrigger;

    //level3
    public bool level3;
    public GameObject FanSwitch;
    public bool exactCode;
    public GameObject lift;
    public bool switchOn;



    private void Start()
    {
        if (level1)
        {
            //Pak yudha
            pakYudha[0].SetActive(true);
            pakYudha[1].SetActive(false);

            //Teknisi
            teknisi[0].SetActive(false);
            teknisi[1].SetActive(false);

            //keyBoard
            keyBoard[0].SetActive(true);
            keyBoard[1].SetActive(false);

            DScript = GameObject.FindGameObjectWithTag("dropPlace").GetComponent<dropScript>();
            EndTrigger.SetActive(false);
        }

        if (level2)
        {
            //Lights
            Lights[0].SetActive(false);
            Lights[1].SetActive(false);
            Lights[2].SetActive(false);
            Lights[3].SetActive(false);

            EndTrigger.SetActive(false);

            
        }

        if (level3)
        {
            //Lights
            Lights[0].SetActive(false);
            FanSwitch.SetActive(false);
            lift.SetActive(false);


        }


    }

    private void Update()
    {
        if (level1)
        {
            if (DScript.index == 3)
            {
                Destroy(pakYudha[0]);
                pakYudha[1].SetActive(true);

                if (teknisi[0] != null)
                {
                    teknisi[0].SetActive(true);
                }

                Destroy(keyBoard[0]);
                keyBoard[1].SetActive(true);

            }
            if (cbScripts != null)
            {
                if (cbScripts.controlPanelON)
                {
                    Destroy(teknisi[0]);
                    teknisi[1].SetActive(true);
                    EndTrigger.SetActive(true);
                }
            }
        }

        if (level2)
        {
            if (RightCode == true)
            {
                Destroy(doorWitchCode);
            } 

            if (end)
            {
                EndTrigger.SetActive(true);
            }
        }

        if (level3)
        {
            if (RightCode == true)
            {
                Destroy(doorWitchCode);
            }

            if (end)
            {
                EndTrigger.SetActive(true);
            }

            if (exactCode)
            {
                FanSwitch.SetActive(true);
            }

            if (switchOn)
            {
                lift.SetActive(true);
            }
        }
      
    }
}
