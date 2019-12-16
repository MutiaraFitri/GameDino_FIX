﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    public static GlobalScript Instance;
    public GameObject nyawa_1;
    public GameObject nyawa_2;
    public GameObject PanelGameOver,panelPause;
    public GameObject nyawa_3;
    public float health=100;
    public int life;
    private float healthAwal;
    public int score=0;
    public bool isPause;

    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Checkpoint",0);
        Instance = this;
        healthAwal = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            PanelGameOver.gameObject.SetActive(true);
            SoundEffectManager.Instance.GameOverSFX();
        }
    }

    public void mati(){
        if(life==3){
            Destroy(nyawa_3);
        }else if(life==2){
            Destroy(nyawa_2);
        }else if(life==1){
            Destroy(nyawa_1);
            gameOver = true;
        }
        life-=1;
    }

    public void matiJatuh(){
            gameOver = true; 
            SoundEffectManager.Instance.GameOverSFX();     
    }

    public float getHealthAwal(){
        return healthAwal;
    }

    public void setPause()
    {
        isPause=true;
        panelPause.gameObject.SetActive(true);
    }

    public void setPlay()
    {
        isPause=false;
        panelPause.gameObject.SetActive(false);
    }
}