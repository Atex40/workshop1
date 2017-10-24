﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomyManager : MonoBehaviour {

    private int currentMoney = 0;
    public int addMoney;

    private int buyItem1Bool;
    private int buyItem2Bool;
    private int buyItem3Bool;

    private int activateItem1Bool;
    private int activateItem2Bool;
    private int activateItem3Bool;
    private int activateItem4Bool;

    private int choixHUD;

    

    // ELEMENTS UI
    public Button quitButton;
    public Button playButton;
    public Button shopButton;
    public Button closeShopButton;
    public Button chooseItem1Button;
    public Button chooseItem2Button;
    public Button chooseItem3Button;
    public Button chooseItem4Button;
    public Image moneyImage;
    public Text highScoreText;
    public Text moneyText;
    public Button buyItem1Button;
    public Button buyItem2Button;
    public Button buyItem3Button;
    public Text infoItem1Text;
    public Text infoItem2Text;
    public Text infoItem3Text;
    public Text infoItem4Text;
    public Text priceItem1Text;
    public Text priceItem2Text;
    public Text priceItem3Text;
    public Text priceItem4Text;
    public GameObject priceItem1Panel;
    public GameObject priceItem2Panel;
    public GameObject priceItem3Panel;
    public GameObject priceItem4Panel;




    // SKIN 1 : ESPACE VERT
    public Sprite quitButtonSkin1;
    public Sprite playButtonSkin1;
    public Sprite shopButtonSkin1;
    public Sprite closeShopButtonSkin1;
    public Sprite moneyImageSkin1;
    public Material skyboxSkin1;
    public Sprite buyItemButtonSkin1;  
    public Sprite chooseItemButtonSkin1;

    // SKIN 2 : ESPACE ROUGE
    public Sprite quitButtonSkin2;
    public Sprite playButtonSkin2;
    public Sprite shopButtonSkin2;
    public Sprite closeShopButtonSkin2;
    public Sprite moneyImageSkin2;
    public Material skyboxSkin2;
    public Sprite buyItemButtonSkin2;
    public Sprite chooseItemButtonSkin2;

    // SKIN 3 : ARCADE NOIR ET BLANC
    public Sprite quitButtonSkin3;
    public Sprite playButtonSkin3;
    public Sprite shopButtonSkin3;
    public Sprite closeShopButtonSkin3;
    public Sprite moneyImageSkin3;
    public Material skyboxSkin3;
    public Sprite buyItemButtonSkin3;
    public Sprite chooseItemButtonSkin3;

    // SKIN 4 : PAR DEFAUT
    public Sprite quitButtonSkin4;
    public Sprite playButtonSkin4;
    public Sprite shopButonSkin4;
    public Sprite closeShopButtonSkin4;
    public Sprite moneyImageSkin4;
    public Material skyboxSkin4;
    public Sprite buyItemButtonSkin4;
    public Sprite chooseItemButtonSkin4;


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
    void Start ()
    {
        
        currentMoney = PlayerPrefs.GetInt("currentMoney");
        activateItem1Bool = PlayerPrefs.GetInt("boolean1");
        activateItem2Bool = PlayerPrefs.GetInt("boolean2");
        activateItem3Bool = PlayerPrefs.GetInt("boolean3");
        activateItem4Bool = PlayerPrefs.GetInt("boolean4");
        buyItem1Bool = PlayerPrefs.GetInt("EspaceVert");
        buyItem2Bool = PlayerPrefs.GetInt("EspaceRouge");
        buyItem3Bool = PlayerPrefs.GetInt("EspacePixel");

        ChooseItemButtonFunction();

      

        if (buyItem1Bool == 1) // SI LE SKIN 1 EST ACHETE
        {
            buyItem1Button.gameObject.SetActive(false);
            priceItem1Panel.gameObject.SetActive(false);
            priceItem1Text.gameObject.SetActive(false);
        }

        if (buyItem2Bool == 1) // SI LE SKIN 2 EST ACHETE
        {
            buyItem2Button.gameObject.SetActive(false);
            priceItem2Panel.gameObject.SetActive(false);
            priceItem2Text.gameObject.SetActive(false);
        }

        if (buyItem3Bool == 1) // SI LE SKIN 3 EST ACHETE
        {
            buyItem3Button.gameObject.SetActive(false);
            priceItem3Panel.gameObject.SetActive(false);
            priceItem3Text.gameObject.SetActive(false);
        }

        if (activateItem1Bool == 1) // SI LE SKIN 1 EST ACTIF
        {
            ChooseItem1();
        }

        if (activateItem2Bool == 1) // SI LE SKIN 2 EST ACTIF
        {
            ChooseItem2();
        }

        if (activateItem3Bool == 1) // SI LE SKIN 3 EST ACTIF
        {
            ChooseItem3();
        }
        

        if (activateItem4Bool == 1) // SI LE SKIN 4 EST ACTIF
        {
            ChooseItem4();
        }

        if (activateItem4Bool == 0 && activateItem1Bool == 0 && activateItem2Bool == 0 && activateItem3Bool == 0)
        {
            ChooseItem4();
            chooseItem4Button.gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
        
        moneyText.text = currentMoney.ToString();
        if (Input.GetKeyDown("c")) // Ajoute monnaie au joueur
        {
            currentMoney = currentMoney + 250;
            Debug.Log("Plus de cash");
            PlayerPrefs.SetInt("currentMoney", currentMoney);
        }

        if (Input.GetKeyDown("v"))
        {
            currentMoney = 0;
            activateItem1Bool = 0;
            activateItem2Bool = 0;
            activateItem3Bool = 0;
            activateItem4Bool = 0;
            buyItem1Bool = 0;
            buyItem2Bool = 0;
            buyItem3Bool = 0;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean1", activateItem1Bool);
            PlayerPrefs.SetInt("boolean2", activateItem2Bool);
            PlayerPrefs.SetInt("boolean3", activateItem3Bool);
            PlayerPrefs.SetInt("boolean4", activateItem4Bool);
            PlayerPrefs.SetInt("EspaceVert", buyItem1Bool);
            PlayerPrefs.SetInt("EspaceRouge", buyItem2Bool);
            PlayerPrefs.SetInt("EspacePixel", buyItem3Bool);
            Debug.Log("jeu reinitialise");
        }

        activateItem1Bool = PlayerPrefs.GetInt("boolean1");
        activateItem2Bool = PlayerPrefs.GetInt("boolean2");
        activateItem3Bool = PlayerPrefs.GetInt("boolean3");
        activateItem4Bool = PlayerPrefs.GetInt("boolean4");

        AffichagePieces();

        if (activateItem1Bool == 1)
        {
            choixHUD = 1;
        }

        if (activateItem2Bool == 1)
        {
            choixHUD = 2;
        }

        if (activateItem3Bool == 1)
        {
            choixHUD = 3;
        }

        if (activateItem4Bool == 1)
        {
            choixHUD = 4;
        }

        PlayerPrefs.SetInt("choixHUD", choixHUD);

    }



    public void BuyItem1() // ACHETER SKIN 1
    {
        if (currentMoney >= 500)
        {
            currentMoney = currentMoney - 500;
            PlayerPrefs.SetInt("currentMoney", currentMoney);

            buyItem1Bool = 1;
            PlayerPrefs.SetInt("EspaceVert", buyItem1Bool);

            Destroy(priceItem1Panel);
            Destroy(priceItem1Text);

            buyItem1Button.gameObject.SetActive(false);
            chooseItem1Button.gameObject.SetActive(true); 
            
            Debug.Log("Item 1 acheté");
        }
       
        else
        {
            Debug.Log("Item 1 ne peut etre acheté");
        }
    }

    public void ChooseItem1() // CHOISIR SKIN 1
    {
        activateItem1Bool = 1;
        activateItem2Bool = 0;
        activateItem3Bool = 0;
        activateItem4Bool = 0;
        PlayerPrefs.SetInt("boolean1", activateItem1Bool);
        PlayerPrefs.SetInt("boolean2", activateItem2Bool);
        PlayerPrefs.SetInt("boolean3", activateItem3Bool);
        PlayerPrefs.SetInt("boolean4", activateItem4Bool);

        ChooseItemButtonFunction();

        RenderSettings.skybox = skyboxSkin1;
        quitButton.image.overrideSprite = quitButtonSkin1;
        playButton.image.overrideSprite = playButtonSkin1;
        shopButton.image.overrideSprite = shopButtonSkin1;
        closeShopButton.image.overrideSprite = closeShopButtonSkin1;

        buyItem2Button.image.overrideSprite = buyItemButtonSkin1;
        buyItem3Button.image.overrideSprite = buyItemButtonSkin1;

        chooseItem2Button.image.overrideSprite = chooseItemButtonSkin1;
        chooseItem3Button.image.overrideSprite = chooseItemButtonSkin1;
        chooseItem4Button.image.overrideSprite = chooseItemButtonSkin1;

        moneyImage.overrideSprite = moneyImageSkin1;

        moneyText.color = Color.green;
        highScoreText.color = Color.green;
        infoItem1Text.color = Color.green;
        infoItem2Text.color = Color.green;
        infoItem3Text.color = Color.green;
        infoItem4Text.color = Color.green;

        if (buyItem2Bool == 0)
        {
            priceItem2Text.color = Color.green;            
        }

        if (buyItem3Bool == 0)
        {
            priceItem3Text.color = Color.green;
        }

        Debug.Log("Item 1 sélectionné");


    }

    public void BuyItem2() // ACHETER SKIN 2
    {
        if (currentMoney >= 1000)
        {
            currentMoney = currentMoney - 1000;
            PlayerPrefs.SetInt("currentMoney", currentMoney);

            buyItem2Bool = 1;            
            PlayerPrefs.SetInt("EspaceRouge", buyItem2Bool);

            Destroy(priceItem2Text);
            Destroy(priceItem2Panel);

            buyItem2Button.gameObject.SetActive(false);
            chooseItem2Button.gameObject.SetActive(true);

            Debug.Log("Item 2 acheté");
        }

        else
        {
        Debug.Log("Item 2 ne peut etre acheté");
        }
    }

    public void ChooseItem2() // CHOISIR SKIN 2
    {
        activateItem1Bool = 0;
        activateItem2Bool = 1;
        activateItem3Bool = 0;
        activateItem4Bool = 0;
        PlayerPrefs.SetInt("boolean1", activateItem1Bool);
        PlayerPrefs.SetInt("boolean2", activateItem2Bool);
        PlayerPrefs.SetInt("boolean3", activateItem3Bool);
        PlayerPrefs.SetInt("boolean4", activateItem4Bool);

        ChooseItemButtonFunction();
        
        RenderSettings.skybox = skyboxSkin2;
        quitButton.image.overrideSprite = quitButtonSkin2;
        playButton.image.overrideSprite = playButtonSkin2;
        shopButton.image.overrideSprite = shopButtonSkin2;
        closeShopButton.image.overrideSprite = closeShopButtonSkin2;

        buyItem1Button.image.overrideSprite = buyItemButtonSkin2;
        buyItem3Button.image.overrideSprite = buyItemButtonSkin2;

        chooseItem1Button.image.overrideSprite = chooseItemButtonSkin2;
        chooseItem3Button.image.overrideSprite = chooseItemButtonSkin2;
        chooseItem4Button.image.overrideSprite = chooseItemButtonSkin2;

        moneyImage.overrideSprite = moneyImageSkin2;

        moneyText.color = Color.red;
        highScoreText.color = Color.red;
        infoItem1Text.color = Color.red;
        infoItem2Text.color = Color.red;
        infoItem3Text.color = Color.red;
        infoItem4Text.color = Color.red;

        if (buyItem1Bool == 0)
        {
            priceItem1Text.color = Color.red;
        }

        if (buyItem3Bool == 0)
        {
            priceItem3Text.color = Color.red;
        }


        Debug.Log("Item 2 sélectionné");
    }

    public void BuyItem3() // ACHETER SKIN 3
    {
        if (currentMoney >= 1500)
        {
            currentMoney = currentMoney - 1500;
            PlayerPrefs.SetInt("currentMoney", currentMoney);

            buyItem3Bool = 1;
            PlayerPrefs.SetInt("EspacePixel", buyItem3Bool);

            Destroy(priceItem3Text);
            Destroy(priceItem3Panel);

            buyItem3Button.gameObject.SetActive(false);
            chooseItem3Button.gameObject.SetActive(true);

            Debug.Log("Item 3 acheté");
        }

        else
        {
        Debug.Log("Item 3 ne peut etre acheté");
        }


    }

    public void ChooseItem3() // CHOISIR SKIN 3
    {

        activateItem1Bool = 0;
        activateItem2Bool = 0;
        activateItem3Bool = 1;
        activateItem4Bool = 0;
        PlayerPrefs.SetInt("boolean1", activateItem1Bool);
        PlayerPrefs.SetInt("boolean2", activateItem2Bool);
        PlayerPrefs.SetInt("boolean3", activateItem3Bool);
        PlayerPrefs.SetInt("boolean4", activateItem4Bool);

        ChooseItemButtonFunction();

        RenderSettings.skybox = skyboxSkin3;
        quitButton.image.overrideSprite = quitButtonSkin3;
        playButton.image.overrideSprite = playButtonSkin3;
        shopButton.image.overrideSprite = shopButtonSkin3;
        closeShopButton.image.overrideSprite = closeShopButtonSkin3;

        buyItem1Button.image.overrideSprite = buyItemButtonSkin3;
        buyItem2Button.image.overrideSprite = buyItemButtonSkin3;

        chooseItem1Button.image.overrideSprite = chooseItemButtonSkin3;
        chooseItem2Button.image.overrideSprite = chooseItemButtonSkin3;
        chooseItem4Button.image.overrideSprite = chooseItemButtonSkin3;

        moneyImage.overrideSprite = moneyImageSkin3;

        moneyText.color = Color.white;
        highScoreText.color = Color.white;
        infoItem1Text.color = Color.white;
        infoItem2Text.color = Color.white;
        infoItem3Text.color = Color.white;
        infoItem4Text.color = Color.white;

        if (buyItem1Bool == 0)
        {
            priceItem1Text.color = Color.white;
        }

        if (buyItem2Bool == 0)
        {
            priceItem2Text.color = Color.white;
        }

        Debug.Log("Item 3 sélectionné");

    }

    public void ChooseItem4() // CHOISIR SKIN 4
    {

        activateItem1Bool = 0;
        activateItem2Bool = 0;
        activateItem3Bool = 0;
        activateItem4Bool = 1;
        PlayerPrefs.SetInt("boolean1", activateItem1Bool);
        PlayerPrefs.SetInt("boolean2", activateItem2Bool);
        PlayerPrefs.SetInt("boolean3", activateItem3Bool);
        PlayerPrefs.SetInt("boolean4", activateItem4Bool);

        ChooseItemButtonFunction();

        RenderSettings.skybox = skyboxSkin4;
        quitButton.image.overrideSprite = quitButtonSkin4;
        playButton.image.overrideSprite = playButtonSkin4;
        shopButton.image.overrideSprite = shopButonSkin4;
        closeShopButton.image.overrideSprite = closeShopButtonSkin4;

        buyItem1Button.image.overrideSprite = buyItemButtonSkin4;
        buyItem2Button.image.overrideSprite = buyItemButtonSkin4;
        buyItem3Button.image.overrideSprite = buyItemButtonSkin4;

        chooseItem1Button.image.overrideSprite = chooseItemButtonSkin4;
        chooseItem2Button.image.overrideSprite = chooseItemButtonSkin4;
        chooseItem3Button.image.overrideSprite = chooseItemButtonSkin4;

        moneyImage.overrideSprite = moneyImageSkin4;

        moneyText.color = Color.blue;
        highScoreText.color = Color.blue;
        infoItem1Text.color = Color.blue;
        infoItem2Text.color = Color.blue;
        infoItem3Text.color = Color.blue;
        infoItem4Text.color = Color.blue;

        if (buyItem1Bool == 0)
        {
            priceItem1Text.color = Color.blue;
        }

        if (buyItem2Bool == 0)
        {
            priceItem2Text.color = Color.blue;
        }

        if (buyItem3Bool == 0)
        {
            priceItem3Text.color = Color.blue;
        }

        Debug.Log("Item 4 sélectionné");

    }

    public void ChooseItemButtonFunction()
    {

        if (buyItem1Bool == 1 && activateItem1Bool == 0) // SI ITEM 1 ACHETE MAIS PAS ACTIF : ACTIVER BOUTON
        {
            chooseItem1Button.gameObject.SetActive(true);
        }

        else if (buyItem1Bool == 0 || activateItem1Bool == 1) // SI ITEM 1 PAS ACHETE OU ACTIF : DESACTIVER BOUTON
        {
            chooseItem1Button.gameObject.SetActive(false);
        }

        if (buyItem2Bool == 1 && activateItem2Bool == 0) // SI ITEM 2 ACHETE MAIS PAS ACTIF : ACTIVER BOUTON
        {
            chooseItem2Button.gameObject.SetActive(true);
        }

        else if (buyItem2Bool == 0 || activateItem2Bool == 1) // SI ITEM 2 PAS ACHETE OU ACTIF : DESACTIVER BOUTON
        {
            chooseItem2Button.gameObject.SetActive(false);
        }

        if (buyItem3Bool == 1 && activateItem3Bool == 0) // SI ITEM 3 ACHETE MAIS PAS ACTIF : ACTIVER BOUTON
        {
            chooseItem3Button.gameObject.SetActive(true);
        }

        else if (buyItem3Bool == 0 || activateItem3Bool == 1) // SI ITEM 3 PAS ACHETE OU ACTIF : DESACTIVER BOUTON
        {
            chooseItem3Button.gameObject.SetActive(false);
        }

        if (activateItem4Bool == 1) // SI ITEM 4 ACTIF : DESACTIVER BOUTON
        {
            chooseItem4Button.gameObject.SetActive(false);
        }

        if (activateItem4Bool == 0) // SI ITEM 4 PAS ACTIF : ACTIVER BOUTON
        {
            chooseItem4Button.gameObject.SetActive(true);
        }

    }

    public void AddMoney () {

        currentMoney += 1;
    }

    public int GetMoney () {

        return currentMoney;
    }

    public void AffichagePieces()
    {
        moneyText.text = currentMoney.ToString();
    }

    public int ChoixSkinHUD()
    {
        return choixHUD;
    }
}
