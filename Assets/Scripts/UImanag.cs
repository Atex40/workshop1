﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class UImanag : MonoBehaviour {
	public Text score;
	public Text scorFinal;
	private int addscore;

	public List<GameObject> lifeObjects;

	private int vie = 2;

	public GameObject canvasHUD;
	public GameObject canvasFin;
	public GameObject cubeFin;

	public Text picesGagnees;

	private static UImanag instance ;
    public static UImanag Instance () 
    {
        return instance;
    }

	void Awake ()
    {
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else 
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AffichageScore();
		CoinsAffichage();
	}

	void AffichageScore () {

     score.text = addscore.ToString("F0");
     scorFinal.text = "Votre Score : " + addscore.ToString("F0");

    }

public void AddScore (){

    	addscore += 10;
    }

public void LooseLife (){

		lifeObjects[vie].SetActive(false);
		vie --;

		if (vie == -1)
		{
			//Time.timeScale = 0;
			canvasHUD.SetActive(false);
			canvasFin.SetActive(true);
			cubeFin.SetActive(false);
			SpawnerManag.Instance().DeactivateiGo();
		}

	}

public void ReturnToMenu()
    {
       // SceneManager.LoadScene("SceneCodeUIPierre");
    }

    void CoinsAffichage () {

    picesGagnees.text = "Pieces gagnees : " + EconomyManager.Instance().GetMoney().ToString();
    	
    }
}
