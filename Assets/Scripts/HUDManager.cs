﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour {

    private int choixUI = EconomyManager.Instance().ChoixSkinHUD();


    // UI DE BASE
    public Button quitButton;
    public Text quitConfirmationText;
    public Button quitYesButton;
    public Button quitNoButton;

    public Button tryAgainButton;
    public Button goToMenuButton;

    public Text scoreText;

    public Text youLooseText;
    public Text finalScoreText;
    public Text moneyWinText;
    public Image moneyImage;

    // SKIN 1 : ESPACE VERT

    public Sprite quitButtonSkin1;
    public Sprite quitYesButtonSkin1;
    public Sprite quitNoButtonSkin1;

    public Sprite tryAgainButtonSkin1;
    public Sprite goToMenuButtonSkin1;

    public Sprite moneyImageSkin1;

    public Material skyboxSkin1;

    // SKIN 2 : ESPACE ROUGE

    public Sprite quitButtonSkin2;
    public Sprite quitYesButtonSkin2;
    public Sprite quitNoButtonSkin2;

    public Sprite tryAgainButtonSkin2;
    public Sprite goToMenuButtonSkin2;

    public Sprite moneyImageSkin2;

    public Material skyboxSkin2;

    // SKIN 3 : ESPACE PIXEL

    public Sprite quitButtonSkin3;
    public Sprite quitYesButtonSkin3;
    public Sprite quitNoButtonSkin3;

    public Sprite tryAgainButtonSkin3;
    public Sprite goToMenuButtonSkin3;

    public Sprite moneyImageSkin3;

    public Material skyboxSkin3;

    // SKIN 4 : DEFAULT

    public Sprite quitButtonSkin4;
    public Sprite quitYesButtonSkin4;
    public Sprite quitNoButtonSkin4;

    public Sprite tryAgainButtonSkin4;
    public Sprite goToMenuButtonSkin4;

    public Sprite moneyImageSkin4;

    public Material skyboxSkin4;

    // Use this for initialization
    void Start () {

        if (choixUI == 1)
        {
            Skin1();
        }

        if (choixUI == 2)
        {
            Skin2();
        }

        if (choixUI == 3)
        {
            Skin3();
        }

        if (choixUI == 4)
        {
            Skin4();
        }
       
	}

    public void Skin1() // SKIN 1 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin1;
        quitYesButton.image.overrideSprite = quitYesButtonSkin1;
        quitNoButton.image.overrideSprite = quitNoButtonSkin1;
        quitConfirmationText.color = Color.green;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin1;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin1;

        RenderSettings.skybox = skyboxSkin1;

        scoreText.color = Color.green;

        moneyImage.overrideSprite = moneyImageSkin1;
        finalScoreText.color = Color.green;
        moneyWinText.color = Color.green;
        youLooseText.color = Color.green;

    }

    public void Skin2() // SKIN 2 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin2;
        quitYesButton.image.overrideSprite = quitYesButtonSkin2;
        quitNoButton.image.overrideSprite = quitNoButtonSkin2;
        quitConfirmationText.color = Color.red;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin2;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin2;

        RenderSettings.skybox = skyboxSkin2;

        scoreText.color = Color.red;

        moneyImage.overrideSprite = moneyImageSkin2;
        finalScoreText.color = Color.red;
        moneyWinText.color = Color.red;
        youLooseText.color = Color.red;
    }

    public void Skin3() // SKIN 3 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin3;
        quitYesButton.image.overrideSprite = quitYesButtonSkin3;
        quitNoButton.image.overrideSprite = quitNoButtonSkin3;
        quitConfirmationText.color = Color.white;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin3;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin3;

        RenderSettings.skybox = skyboxSkin3;

        scoreText.color = Color.white;

        moneyImage.overrideSprite = moneyImageSkin3;
        finalScoreText.color = Color.white;
        moneyWinText.color = Color.white;
        youLooseText.color = Color.white;
    }

    public void Skin4() // SKIN 4 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin4;
        quitYesButton.image.overrideSprite = quitYesButtonSkin4;
        quitNoButton.image.overrideSprite = quitNoButtonSkin4;
        quitConfirmationText.color = Color.blue;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin4;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin4;

        RenderSettings.skybox = skyboxSkin4;

        scoreText.color = Color.blue;

        moneyImage.overrideSprite = moneyImageSkin4;
        finalScoreText.color = Color.blue;
        moneyWinText.color = Color.blue;
        youLooseText.color = Color.blue;
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("InGame");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}