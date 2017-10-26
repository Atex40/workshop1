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

	private int countVieReset;

	public AudioSource defaiteSound;

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
		Debug.Log("yop");
	}
	
	// Update is called once per frame
	void Update () {
		// AffichageScore();
		// CoinsAffichage();


		if (Input.GetKeyDown("e")){
			AddScore(500);
			CountVie(500);
		}

		// WinLife ();

		// PlayerPrefs.SetInt("currentMoney", EconomyManager.Instance().GetMoney());
	}

	void AffichageScore () {

     score.text = addscore.ToString("F0");
     scorFinal.text = "Votre Score : " + addscore.ToString("F0");

    }

public void AddScore (int value){

    	addscore += value;
    	AffichageScore();

    }

public void LooseLife (){

		lifeObjects[vie].SetActive(false);
		vie --;
		Camera.main.GetComponent<PerlinShake>().PlayShake();

		if (vie == -1)
		{
			defaiteSound.Play();
			//Time.timeScale = 0;
			canvasHUD.SetActive(false);
			canvasFin.SetActive(true);
			cubeFin.SetActive(false);
			gameOnOff = false;
			CoinsAffichage();
			PlayerPrefs.SetInt("currentMoney", EconomyManager.Instance().GetMoney());
			Destroy (GameObject.FindGameObjectWithTag("Vert"));
			Destroy (GameObject.FindGameObjectWithTag("Bleu"));
			Destroy (GameObject.FindGameObjectWithTag("Rouge"));
		}
	}

	void WinLife ()
	{
		if (countVieReset == 2500)
		{
			vie ++;
			lifeObjects[vie].SetActive(true);
			countVieReset = 0;
		}		
	}

    void CoinsAffichage () {

    picesGagnees.text = "Pieces Totales	 : " + EconomyManager.Instance().GetMoney().ToString();
    	
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

public void CountVie (int value){

	countVieReset += value;
	WinLife ();
}
}
