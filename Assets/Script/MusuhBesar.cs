﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusuhBesar : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer=2 ;
    public GameObject musuh;
    private int rotate=0;
    private float arah= -0.025f ;
    void Start()
    {
        musuh.GetComponent<GameObject>();

    // Update is called once per frame
    void Update()
    {
        timer -= 0.025f ;
        if( timer > 0 )
        {
            musuh.transform.Translate(arah,0,0);
        }
        else {
            musuh.transform.Rotate(0,rotate+180,0);
            // arah = arah*-1;
            timer = 2;
        }
    }
}}


