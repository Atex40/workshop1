﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomyManager : MonoBehaviour {

    private int currentMoney = 0;
    public int addMoney;
    private int bi1YES;
    private int bi2YES;
    private int bi3YES;

    public Material skybox2;

    // ELEMENTS UI
    public Button quitButton;
    public Button playButton;
    public Button shopButton;
    public Button unlockBuy1;
    public Button unlockBuy2;
    public Button unlockBuy3;
    public Image moneyLogo;
    public Text highScore;
    public Text money;
    public GameObject buy1Button;
    public GameObject buy2Button;
    public GameObject buy3Button;

    // SKIN DE BASE
    public Sprite quitSprite1;
    public Sprite playSprite1;
    public Sprite shopSprite1;
    public Sprite moneySprite1;

    // SKIN ESPACE VERT
    public Sprite quitSprite2;
    public Sprite playSprite2;
    public Sprite shopSprite2;
    public Sprite moneyImage2;

    private static EconomyManager instance;
    public static EconomyManager Instance()
    {
        return instance;
    }
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        currentMoney = PlayerPrefs.GetInt("currentMoney");
        bi1YES = PlayerPrefs.GetInt("boolean1");
        bi2YES = PlayerPrefs.GetInt("boolean2");
        bi3YES = PlayerPrefs.GetInt("boolean3");

        if (bi1YES == 1)
        {
            Destroy(buy1Button);
            RenderSettings.skybox = skybox2;
        }

        if (bi2YES == 1)
        {
            Destroy(buy2Button);
        }

        if (bi3YES == 1)
        {
            Destroy(buy3Button);
        }
    }
	
	// Update is called once per frame
	void Update () {

        money.text = currentMoney.ToString();
        if (Input.GetKeyDown("c")) // Ajoute monnaie au joueur
        {
            currentMoney = currentMoney + 250;
            Debug.Log("Plus de cash");
            PlayerPrefs.SetInt("currentMoney", currentMoney);
        }

        if (Input.GetKeyDown("v"))
        {
            currentMoney = 0;
            bi1YES = 0;
            bi2YES = 0;
            bi3YES = 0;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean1", bi1YES);
            PlayerPrefs.SetInt("boolean2", bi2YES);
            PlayerPrefs.SetInt("boolean3", bi3YES);
            Debug.Log("monnaie reinitialisee");
        }

	}



    public void BuyItem1()
    {
        if (currentMoney >= 500 && bi1YES == 0)
        {
            Destroy(buy1Button);
            currentMoney = currentMoney - 500;
            bi1YES = 1;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean1", bi1YES);
            Debug.Log("Item 1 acheté");

            RenderSettings.skybox = skybox2;
            quitButton.image.overrideSprite = quitSprite2;
            playButton.image.overrideSprite = playSprite2;
            shopButton.image.overrideSprite = shopSprite2;
            money.color = Color.green;
            highScore.color = Color.green;
            moneyLogo.sprite = moneyImage2;
            
        }
        else
        {
            Debug.Log("Item 1 ne peut etre acheté");
        }
    }

    public void BuyItem2()
    {
        if (currentMoney >= 1000 && bi2YES == 0)
        {
            currentMoney = currentMoney - 1000;
            bi2YES = 1;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean2", bi2YES);
            Destroy(buy2Button);
            Debug.Log("Item 2 acheté");
        }
        else
        {
        Debug.Log("Item 2 ne peut etre acheté");
        }
    }

    public void BuyItem3()
    {
        if (currentMoney >= 1500 && bi3YES == 0)
        {
            currentMoney = currentMoney - 1500;
            bi3YES = 1;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean3", bi3YES);
            Destroy(buy3Button);
            Debug.Log("Item 3 acheté");
        }
        else
        {
        Debug.Log("Item 3 ne peut etre acheté");
        }
    }



    public void AddMoney () {

        currentMoney += 1;
    }

    public int GetMoney () {

        return currentMoney;
    }
}
