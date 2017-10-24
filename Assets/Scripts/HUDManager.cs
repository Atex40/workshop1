using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    private int choixUI = EconomyManager.Instance().ChoixSkinHUD();


    // UI DE BASE
    public Button quitButton;
    public Text quitConfirmationText;
    public Button quitYesButton;
    public Button quitNoButton;

    public Text scoreText;

    public Text youLooseText;
    public Text finalScoreText;
    public Text moneyWinText;
    public Image moneyImage;

    // SKIN 1 : ESPACE VERT

    public Sprite quitButtonSkin1;
    public Sprite quitYesButtonSkin1;
    public Sprite quitNoButtonSkin1;

    public Sprite moneyImageSkin1;

    // SKIN 2 : ESPACE ROUGE

    public Sprite quitButtonSkin2;
    public Sprite quitYesButtonSkin2;
    public Sprite quitNoButtonSkin2;

    public Sprite moneyImageSkin2;

    // SKIN 3 : ESPACE PIXEL

    public Sprite quitButtonSkin3;
    public Sprite quitYesButtonSkin3;
    public Sprite quitNoButtonSkin3;

    public Sprite moneyImageSkin3;

    // SKIN 4 : DEFAULT

    public Sprite quitButtonSkin4;
    public Sprite quitYesButtonSkin4;
    public Sprite quitNoButtonSkin4;

    public Sprite moneyImageSkin4;

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

    public void Skin1()
    {
        quitButton.image.overrideSprite = quitButtonSkin1;
        quitYesButton.image.overrideSprite = quitYesButtonSkin1;
        quitNoButton.image.overrideSprite = quitNoButtonSkin1;
        quitConfirmationText.color = Color.green;

        scoreText.color = Color.green;

        moneyImage.overrideSprite = moneyImageSkin1;
        finalScoreText.color = Color.green;
        moneyWinText.color = Color.green;
        youLooseText.color = Color.green;

    }

    public void Skin2()
    {
        quitButton.image.overrideSprite = quitButtonSkin2;
        quitYesButton.image.overrideSprite = quitYesButtonSkin2;
        quitNoButton.image.overrideSprite = quitNoButtonSkin2;
        quitConfirmationText.color = Color.red;

        scoreText.color = Color.red;

        moneyImage.overrideSprite = moneyImageSkin2;
        finalScoreText.color = Color.red;
        moneyWinText.color = Color.red;
        youLooseText.color = Color.red;
    }

    public void Skin3()
    {
        quitButton.image.overrideSprite = quitButtonSkin3;
        quitYesButton.image.overrideSprite = quitYesButtonSkin3;
        quitNoButton.image.overrideSprite = quitNoButtonSkin3;
        quitConfirmationText.color = Color.white;

        scoreText.color = Color.white;

        moneyImage.overrideSprite = moneyImageSkin3;
        finalScoreText.color = Color.white;
        moneyWinText.color = Color.white;
        youLooseText.color = Color.white;
    }

    public void Skin4()
    {
        quitButton.image.overrideSprite = quitButtonSkin4;
        quitYesButton.image.overrideSprite = quitYesButtonSkin4;
        quitNoButton.image.overrideSprite = quitNoButtonSkin4;
        quitConfirmationText.color = Color.blue;

        scoreText.color = Color.blue;

        moneyImage.overrideSprite = moneyImageSkin4;
        finalScoreText.color = Color.blue;
        moneyWinText.color = Color.blue;
        youLooseText.color = Color.blue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
