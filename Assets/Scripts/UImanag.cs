using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UImanag : MonoBehaviour {
	public Text score;
	private int addscore;

	public List<GameObject> lifeObjects;
	public List<GameObject> objSetActive;

	private int vie = 2;

	public GameObject canvasHUD;
	public GameObject canvasFin;

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
	}

	void AffichageScore () {

     score.text = addscore.ToString("F0");

    }

public void AddScore (){

    	addscore += 10;
    }

public void LooseLife (){

		lifeObjects[vie].SetActive(false);
		vie --;

		if (vie == -1)
		{
			canvasHUD.SetActive(false);
			canvasFin.SetActive(true);

		}

	}
}
