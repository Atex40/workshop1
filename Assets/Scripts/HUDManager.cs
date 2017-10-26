using System.Collections;
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

    public Image vie1;
    public Image vie2;
    public Image vie3;
    public Image vie4;
    public Image vie5;

    public Button tryAgainButton;
    public Button goToMenuButton;

    public Text scoreText;
    public Font basicFont;
    public Font pixelFont;

    public Text youLooseText;
    public Text finalScoreText;
    public Text moneyWinText;
    public Image moneyImage;

    public GameObject confirmPanel;

    private AudioSource selectSound;
    public AudioClip selectSoundClip;


    // SKIN 1 : ESPACE VERT

    public Sprite quitButtonSkin1;
    public Sprite quitYesButtonSkin1;
    public Sprite quitNoButtonSkin1;

    public Sprite vieSkin1;

    public Sprite tryAgainButtonSkin1;
    public Sprite goToMenuButtonSkin1;

    public Sprite moneyImageSkin1;

    public Material skyboxSkin1;

    // SKIN 2 : ESPACE ROUGE

    public Sprite quitButtonSkin2;
    public Sprite quitYesButtonSkin2;
    public Sprite quitNoButtonSkin2;

    public Sprite vieSkin2;

    public Sprite tryAgainButtonSkin2;
    public Sprite goToMenuButtonSkin2;

    public Sprite moneyImageSkin2;

    public Material skyboxSkin2;

    // SKIN 3 : ESPACE PIXEL

    public Sprite quitButtonSkin3;
    public Sprite quitYesButtonSkin3;
    public Sprite quitNoButtonSkin3;

    public Sprite vieSkin3;

    public Sprite tryAgainButtonSkin3;
    public Sprite goToMenuButtonSkin3;

    public Sprite moneyImageSkin3;

    public Material skyboxSkin3;

    // SKIN 4 : DEFAULT

    public Sprite quitButtonSkin4;
    public Sprite quitYesButtonSkin4;
    public Sprite quitNoButtonSkin4;

    public Sprite vieSkin4;

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

        selectSound = GetComponent<AudioSource>();
       
	}

    public void PlaySelectSound()
    {
        selectSound.PlayOneShot(selectSoundClip, 1);
    }

    public void OpenConfirmPanel()
    {
        confirmPanel.SetActive(true);
    }

    public void CloseConfirmPanel()
    {
        confirmPanel.SetActive(false);
    }

    public void Skin1() // SKIN 1 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin1;
        quitYesButton.image.overrideSprite = quitYesButtonSkin1;
        quitNoButton.image.overrideSprite = quitNoButtonSkin1;
        quitConfirmationText.color = Color.green;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin1;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin1;

        vie1.overrideSprite = vieSkin1;
        vie2.overrideSprite = vieSkin1;
        vie3.overrideSprite = vieSkin1;
        vie4.overrideSprite = vieSkin1;
        vie5.overrideSprite = vieSkin1;

        RenderSettings.skybox = skyboxSkin1;

        scoreText.color = Color.green;
        scoreText.font = basicFont;

        //moneyImage.overrideSprite = moneyImageSkin1;
        finalScoreText.color = Color.green;
        finalScoreText.font = basicFont;
        moneyWinText.color = Color.green;
        moneyWinText.font = basicFont;
        youLooseText.color = Color.green;
        youLooseText.font = basicFont;

    }

    public void Skin2() // SKIN 2 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin2;
        quitYesButton.image.overrideSprite = quitYesButtonSkin2;
        quitNoButton.image.overrideSprite = quitNoButtonSkin2;
        quitConfirmationText.color = Color.red;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin2;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin2;

        vie1.overrideSprite = vieSkin2;
        vie2.overrideSprite = vieSkin2;
        vie3.overrideSprite = vieSkin2;
        vie4.overrideSprite = vieSkin2;
        vie5.overrideSprite = vieSkin2;

        RenderSettings.skybox = skyboxSkin2;

        scoreText.color = Color.red;
        scoreText.font = basicFont;

        //moneyImage.overrideSprite = moneyImageSkin2;
        finalScoreText.color = Color.red;
        finalScoreText.font = basicFont;
        moneyWinText.color = Color.red;
        moneyWinText.font = basicFont;
        youLooseText.color = Color.red;
        youLooseText.font = basicFont;
    }

    public void Skin3() // SKIN 3 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin3;
        quitYesButton.image.overrideSprite = quitYesButtonSkin3;
        quitNoButton.image.overrideSprite = quitNoButtonSkin3;
        quitConfirmationText.color = Color.white;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin3;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin3;

        vie1.overrideSprite = vieSkin3;
        vie2.overrideSprite = vieSkin3;
        vie3.overrideSprite = vieSkin3;
        vie4.overrideSprite = vieSkin3;
        vie5.overrideSprite = vieSkin3;

        RenderSettings.skybox = skyboxSkin3;

        scoreText.color = Color.white;
        scoreText.font = pixelFont;

        //moneyImage.overrideSprite = moneyImageSkin3;
        finalScoreText.color = Color.white;
        finalScoreText.font = pixelFont;
        moneyWinText.color = Color.white;
        moneyWinText.font = pixelFont;
        youLooseText.color = Color.white;
        youLooseText.font = pixelFont;
    }

    public void Skin4() // SKIN 4 ACTIF
    {
        quitButton.image.overrideSprite = quitButtonSkin4;
        quitYesButton.image.overrideSprite = quitYesButtonSkin4;
        quitNoButton.image.overrideSprite = quitNoButtonSkin4;
        quitConfirmationText.color = Color.white;

        tryAgainButton.image.overrideSprite = tryAgainButtonSkin4;
        goToMenuButton.image.overrideSprite = goToMenuButtonSkin4;

        vie1.overrideSprite = vieSkin4;
        vie2.overrideSprite = vieSkin4;
        vie3.overrideSprite = vieSkin4;
        vie4.overrideSprite = vieSkin4;
        vie5.overrideSprite = vieSkin4;

        RenderSettings.skybox = skyboxSkin4;

        scoreText.color = Color.white;
        scoreText.font = basicFont;

        //moneyImage.overrideSprite = moneyImageSkin4;
        finalScoreText.color = Color.white;
        finalScoreText.font = basicFont;
        moneyWinText.color = Color.white;
        moneyWinText.font = basicFont;
        youLooseText.color = Color.white;
        youLooseText.font = basicFont;
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
