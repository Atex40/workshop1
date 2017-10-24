using System.Collections;
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

	private bool gameOnOff = true;

	public GameObject canvasMMIG;

	public bool addVie = true;
	private int countVieReset = 0;

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


		if (Input.GetKeyDown("e")){
		Debug.Log(Input.GetKeyDown("e"));
		addscore +=500;
		}

		WinLife ();
	}

	void AffichageScore () {

     score.text = addscore.ToString("F0");
     scorFinal.text = "Votre Score : " + addscore.ToString("F0");

    }

public void AddScore (){

    	addscore += 100;

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
			gameOnOff = false;
		}
	}

	void WinLife ()
	{
		if (addVie)
		{
			if (addscore == 2500)
		{
			vie ++;
			lifeObjects[vie].SetActive(true);
			addVie = false;
		}
	}
		
	}

    void CoinsAffichage () {

    picesGagnees.text = "Pieces gagnees : " + EconomyManager.Instance().GetMoney().ToString();
    	
    }

public int ScoreSpeed () {

	return addscore;

	}

public bool IsGameOn () {

	return gameOnOff;

	}

public	void Recommencer () {

		SceneManager.LoadScene("SceneFinalIG");
	}

public void MainMenuIG () {

	canvasMMIG.SetActive(true);
}

public void BackMenuOui () {

	SceneManager.LoadScene("MainMenu");
}

public void BackMenuNon () {

	canvasMMIG.SetActive(false);
}
}
