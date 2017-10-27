using System.Collections;
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
    public GameObject shopPanel; 

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

    public Image checkItemChoice1;
    public Image checkItemChoice2;
    public Image checkItemChoice3;
    public Image checkItemChoice4;

    public Button tutorialButton;
    public Button closeTutorialButton;

    public Text tutorialTextUp;
    public Text tutorialTextDown;

    public Font pixelFont;
    public Font basicFont;
    public Font arialFont;

    public Image cadenas1;
    public Image cadenas2;
    public Image cadenas3;

    public Text achatBronze;
    public Text achatArgent;
    public Text achatOr;

    public Text recompenseBronze;
    public Text recompenseArgent;
    public Text recompenseOr;

    public GameObject confirmerAchatBronzePanel;
    public GameObject ConfirmerAchatArgentPanel;
    public GameObject ConfirmerAchatOrPanel;

    public GameObject thanksBronzePanel;
    public GameObject thanksArgentPanel;
    public GameObject thanksOrPanel;

    private AudioSource selectSound;
    public AudioClip selectSoundClip;

    private int langage;


    // SKIN 1 : ESPACE VERT
    public Sprite quitButtonSkin1;
    public Sprite playButtonSkin1FR;
    public Sprite playButtonSkin1ENG;
    public Sprite shopButtonSkin1;
    public Sprite closeShopButtonSkin1;
    public Sprite moneyImageSkin1;
    public Material skyboxSkin1;
    public Sprite buyItemButtonSkin1FR;
    public Sprite buyItemButtonSkin1ENG;
    public Sprite chooseItemButtonSkin1FR;
    public Sprite chooseItemButtonSkin1ENG;
    public Sprite tutorialButtonSkin1FR;
    public Sprite tutorialButtonSkin1ENG;
    public Sprite closeTutorialButtonSkin1;
    public Sprite cadenasOpened1;

    // SKIN 2 : ESPACE ROUGE
    public Sprite quitButtonSkin2;
    public Sprite playButtonSkin2FR;
    public Sprite playButtonSkin2ENG;
    public Sprite shopButtonSkin2;
    public Sprite closeShopButtonSkin2;
    public Sprite moneyImageSkin2;
    public Material skyboxSkin2;
    public Sprite buyItemButtonSkin2FR;
    public Sprite buyItemButtonSkin2ENG;
    public Sprite chooseItemButtonSkin2FR;
    public Sprite chooseItemButtonSkin2ENG;
    public Sprite tutorialButtonSkin2FR;
    public Sprite tutorialButtonSkin2ENG;
    public Sprite closeTutorialButtonSkin2;
    public Sprite cadenasOpened2;

    // SKIN 3 : ARCADE NOIR ET BLANC
    public Sprite quitButtonSkin3;
    public Sprite playButtonSkin3FR;
    public Sprite playButtonSkin3ENG;
    public Sprite shopButtonSkin3;
    public Sprite closeShopButtonSkin3;
    public Sprite moneyImageSkin3;
    public Material skyboxSkin3;
    public Sprite buyItemButtonSkin3FR;
    public Sprite buyItemButtonSkin3ENG;
    public Sprite chooseItemButtonSkin3FR;
    public Sprite chooseItemButtonSkin3ENG;
    public Sprite tutorialButtonSkin3FR;
    public Sprite tutorialButtonSkin3ENG;
    public Sprite closeTutorialButtonSkin3;
    public Sprite cadenasOpened3;

    // SKIN 4 : PAR DEFAUT
    public Sprite quitButtonSkin4;
    public Sprite playButtonSkin4FR;
    public Sprite playButtonSkin4ENG;
    public Sprite shopButonSkin4;
    public Sprite closeShopButtonSkin4;
    public Sprite moneyImageSkin4;
    public Material skyboxSkin4;
    public Sprite buyItemButtonSkin4FR;
    public Sprite buyItemButtonSkin4ENG;
    public Sprite chooseItemButtonSkin4FR;
    public Sprite chooseItemButtonSkin4ENG;
    public Sprite tutorialButtonSkin4FR;
    public Sprite tutorialButtonSkin4ENG;
    public Sprite closeTutorialButtonSkin4;


    private static EconomyManager instance;

    public static EconomyManager Instance()
    {
        return instance;
    }

    public void ChangerLangage()
    {

        langage = PlayerPrefs.GetInt("choixLangage");

        if (langage == 1)
        {
            tutorialTextUp.text = "Pour faire pivoter le cube, faites glisser votre doigt dans la direction des flèches indiquées.";
            tutorialTextDown.text = "Faites correspondre les couleurs des faces du cube avec celles des objets arrivants pour gagner des points.";
            highScoreText.text = "MEILLEUR SCORE : ";
            infoItem4Text.text = "DEFAUT";
            recompenseBronze.text = "500 pièces";
            recompenseArgent.text = "1700 pièces";
            recompenseOr.text = "4800 pièces";

            if (activateItem1Bool == 1) // SI SKIN 1 ET LANGUE FR
            {
                playButton.image.overrideSprite = playButtonSkin1FR;


                tutorialButton.image.overrideSprite = tutorialButtonSkin1FR;

                buyItem2Button.image.overrideSprite = buyItemButtonSkin1FR;
                buyItem3Button.image.overrideSprite = buyItemButtonSkin1FR;

                chooseItem2Button.image.overrideSprite = chooseItemButtonSkin1FR;
                chooseItem3Button.image.overrideSprite = chooseItemButtonSkin1FR;
                chooseItem4Button.image.overrideSprite = chooseItemButtonSkin1FR;

                langage = 0;
                PlayerPrefs.SetInt("choixLangage", langage);
            }

            else if (activateItem2Bool == 1) // SI SKIN 2 ET LANGUE FR
            {
                //PlayerPrefs.SetInt("choixLangage", langage);

                playButton.image.overrideSprite = playButtonSkin2FR;

                tutorialButton.image.overrideSprite = tutorialButtonSkin2FR;

                buyItem1Button.image.overrideSprite = buyItemButtonSkin2FR;
                buyItem3Button.image.overrideSprite = buyItemButtonSkin2FR;

                chooseItem1Button.image.overrideSprite = chooseItemButtonSkin2FR;
                chooseItem3Button.image.overrideSprite = chooseItemButtonSkin2FR;
                chooseItem4Button.image.overrideSprite = chooseItemButtonSkin2FR;

                langage = 0;

                PlayerPrefs.SetInt("choixLangage", langage);
            }

            else if (activateItem3Bool == 1) // SI SKIN 3 ET LANGUE FR
            {
                //   PlayerPrefs.SetInt("choixLangage", langage);

                playButton.image.overrideSprite = playButtonSkin3FR;

                tutorialButton.image.overrideSprite = tutorialButtonSkin3FR;

                buyItem1Button.image.overrideSprite = buyItemButtonSkin3FR;
                buyItem2Button.image.overrideSprite = buyItemButtonSkin3FR;

                chooseItem1Button.image.overrideSprite = chooseItemButtonSkin3FR;
                chooseItem2Button.image.overrideSprite = chooseItemButtonSkin3FR;
                chooseItem4Button.image.overrideSprite = chooseItemButtonSkin3FR;

                langage = 0;

                PlayerPrefs.SetInt("choixLangage", langage);
            }

            else if (activateItem4Bool == 1) // SI SKIN 4 ET LANGUE FR
            {
                playButton.image.overrideSprite = playButtonSkin4FR;

                tutorialButton.image.overrideSprite = tutorialButtonSkin4FR;

                buyItem1Button.image.overrideSprite = buyItemButtonSkin4FR;
                buyItem2Button.image.overrideSprite = buyItemButtonSkin4FR;
                buyItem3Button.image.overrideSprite = buyItemButtonSkin4FR;

                chooseItem1Button.image.overrideSprite = chooseItemButtonSkin4FR;
                chooseItem2Button.image.overrideSprite = chooseItemButtonSkin4FR;
                chooseItem3Button.image.overrideSprite = chooseItemButtonSkin4FR;

                langage = 0;

                PlayerPrefs.SetInt("choixLangage", langage);
            }

        }

        else if (langage == 0)
        {
            tutorialTextUp.text = "To rotate the cube, swipe your finger in direction of indicated arrows.";
            tutorialTextDown.text = "Make your cube's faces colors match with incoming items.";
            highScoreText.text = "HIGHSCORE : ";
            infoItem4Text.text = "DEFAULT";
            recompenseBronze.text = "500 coins";
            recompenseArgent.text = "1700 coins";
            recompenseOr.text = "4800 coins";

             if (activateItem1Bool == 1) // SI SKIN 1 ET LANGUE ENG
            {
                // PlayerPrefs.SetInt("choixLangage", langage);

                playButton.image.overrideSprite = playButtonSkin1ENG;

                tutorialButton.image.overrideSprite = tutorialButtonSkin1ENG;

                buyItem2Button.image.overrideSprite = buyItemButtonSkin1ENG;
                buyItem3Button.image.overrideSprite = buyItemButtonSkin1ENG;

                chooseItem2Button.image.overrideSprite = chooseItemButtonSkin1ENG;
                chooseItem3Button.image.overrideSprite = chooseItemButtonSkin1ENG;
                chooseItem4Button.image.overrideSprite = chooseItemButtonSkin1ENG;

                langage = 1;

                PlayerPrefs.SetInt("choixLangage", langage);
            }



            else if (activateItem2Bool == 1) // SI SKIN 2 ET LANGUE ENG
            {
                // PlayerPrefs.SetInt("choixLangage", langage);

                playButton.image.overrideSprite = playButtonSkin2ENG;

                tutorialButton.image.overrideSprite = tutorialButtonSkin2ENG;

                buyItem1Button.image.overrideSprite = buyItemButtonSkin2ENG;
                buyItem3Button.image.overrideSprite = buyItemButtonSkin2ENG;

                chooseItem1Button.image.overrideSprite = chooseItemButtonSkin2ENG;
                chooseItem3Button.image.overrideSprite = chooseItemButtonSkin2ENG;
                chooseItem4Button.image.overrideSprite = chooseItemButtonSkin2ENG;

                langage = 1;

                PlayerPrefs.SetInt("choixLangage", langage);

            }



            else if (activateItem3Bool == 1) // SI SKIN 3 ET LANGUE ENG
            {
                playButton.image.overrideSprite = playButtonSkin3ENG;

                tutorialButton.image.overrideSprite = tutorialButtonSkin3ENG;

                buyItem1Button.image.overrideSprite = buyItemButtonSkin3ENG;
                buyItem2Button.image.overrideSprite = buyItemButtonSkin3ENG;

                chooseItem1Button.image.overrideSprite = chooseItemButtonSkin3ENG;
                chooseItem2Button.image.overrideSprite = chooseItemButtonSkin3ENG;
                chooseItem4Button.image.overrideSprite = chooseItemButtonSkin3ENG;

                langage = 1;

                PlayerPrefs.SetInt("choixLangage", langage);
            }



            else if (activateItem4Bool == 1)
            {
                playButton.image.overrideSprite = playButtonSkin4ENG;

                tutorialButton.image.overrideSprite = tutorialButtonSkin4ENG;

                buyItem1Button.image.overrideSprite = buyItemButtonSkin4ENG;
                buyItem2Button.image.overrideSprite = buyItemButtonSkin4ENG;
                buyItem3Button.image.overrideSprite = buyItemButtonSkin4ENG;

                chooseItem1Button.image.overrideSprite = chooseItemButtonSkin4ENG;
                chooseItem2Button.image.overrideSprite = chooseItemButtonSkin4ENG;
                chooseItem3Button.image.overrideSprite = chooseItemButtonSkin4ENG;

                langage = 1;

                PlayerPrefs.SetInt("choixLangage", langage);
            }

        }

       
      
       

        
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
        langage = PlayerPrefs.GetInt("choixLangage");

        if (langage != 0 && langage !=1)
        {
            langage = 0;
            PlayerPrefs.SetInt("choixLangage", langage);
        }

        ChangerLangage();
        
        

        infoItem1Text.color = Color.green;
        infoItem2Text.color = Color.red;
        infoItem3Text.color = Color.white;
        infoItem4Text.color = Color.white;
        currentMoney = PlayerPrefs.GetInt("currentMoney");
        activateItem1Bool = PlayerPrefs.GetInt("boolean1");
        activateItem2Bool = PlayerPrefs.GetInt("boolean2");
        activateItem3Bool = PlayerPrefs.GetInt("boolean3");
        activateItem4Bool = PlayerPrefs.GetInt("boolean4");
        buyItem1Bool = PlayerPrefs.GetInt("EspaceVert");
        buyItem2Bool = PlayerPrefs.GetInt("EspaceRouge");
        buyItem3Bool = PlayerPrefs.GetInt("EspacePixel");

        selectSound = GetComponent<AudioSource>();

        ChooseItemButtonFunction();

      

        if (buyItem1Bool == 1) // SI LE SKIN 1 EST ACHETE
        {
            cadenas1.overrideSprite = cadenasOpened1;
            buyItem1Button.gameObject.SetActive(false);
            priceItem1Panel.gameObject.SetActive(false);
            priceItem1Text.gameObject.SetActive(false);
        }

        if (buyItem2Bool == 1) // SI LE SKIN 2 EST ACHETE
        {
            cadenas2.overrideSprite = cadenasOpened2;
            buyItem2Button.gameObject.SetActive(false);
            priceItem2Panel.gameObject.SetActive(false);
            priceItem2Text.gameObject.SetActive(false);
        }

        if (buyItem3Bool == 1) // SI LE SKIN 3 EST ACHETE
        {
            cadenas3.overrideSprite = cadenasOpened3;
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

    public void PlaySelectSound()
    {
        selectSound.PlayOneShot(selectSoundClip, 1F);
    }

    // Update is called once per frame
    void Update ()
    {

     

        currentMoney = PlayerPrefs.GetInt("currentMoney");
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
            langage = 0;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean1", activateItem1Bool);
            PlayerPrefs.SetInt("boolean2", activateItem2Bool);
            PlayerPrefs.SetInt("boolean3", activateItem3Bool);
            PlayerPrefs.SetInt("boolean4", activateItem4Bool);
            PlayerPrefs.SetInt("EspaceVert", buyItem1Bool);
            PlayerPrefs.SetInt("EspaceRouge", buyItem2Bool);
            PlayerPrefs.SetInt("EspacePixel", buyItem3Bool);
            PlayerPrefs.SetInt("choixLangage", langage);
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

            cadenas1.overrideSprite = cadenasOpened1;
            
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

        langage = PlayerPrefs.GetInt("choixLangage");

        ChangerLangage();

        quitButton.image.overrideSprite = quitButtonSkin1;

        shopButton.image.overrideSprite = shopButtonSkin1;

        closeTutorialButton.image.overrideSprite = closeTutorialButtonSkin1;
        closeShopButton.image.overrideSprite = closeShopButtonSkin1;

        RenderSettings.skybox = skyboxSkin1;
        
        tutorialTextUp.color = Color.green;
        tutorialTextDown.color = Color.green;

        tutorialTextUp.font = basicFont;
        tutorialTextDown.font = basicFont;
        moneyText.font = basicFont;
        highScoreText.font = basicFont;


        //achatBronze.color = Color.green;
        //achatBronze.font = basicFont;

        //achatArgent.color = Color.green;
        //achatArgent.font = basicFont;

        //achatOr.color = Color.green;
        //achatOr.font = basicFont;

        // recompenseBronze.color = Color.green;
        //recompenseBronze.font = arialFont;

        //recompenseArgent.color = Color.green;
        //recompenseArgent.font = arialFont;

        //recompenseOr.color = Color.green;
        //recompenseOr.font = arialFont;

        checkItemChoice1.gameObject.SetActive(true);
        checkItemChoice2.gameObject.SetActive(false);
        checkItemChoice3.gameObject.SetActive(false);
        checkItemChoice4.gameObject.SetActive(false);

        moneyImage.overrideSprite = moneyImageSkin4;

        moneyText.color = Color.green;
        highScoreText.color = Color.green;
        //infoItem1Text.color = Color.green;
        //infoItem2Text.color = Color.green;
        //infoItem3Text.color = Color.green;
        //infoItem4Text.color = Color.green;

        if (buyItem2Bool == 0)
        {
            priceItem2Text.font = basicFont;
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

            cadenas2.overrideSprite = cadenasOpened2;

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
        playButton.image.overrideSprite = playButtonSkin2FR;
        shopButton.image.overrideSprite = shopButtonSkin2;
        closeShopButton.image.overrideSprite = closeShopButtonSkin2;

        tutorialButton.image.overrideSprite = tutorialButtonSkin2FR;
        tutorialTextUp.color = Color.red;
        tutorialTextDown.color = Color.red;

        tutorialTextDown.font = basicFont;
        tutorialTextUp.font = basicFont;
        moneyText.font = basicFont;
        highScoreText.font = basicFont;

        buyItem1Button.image.overrideSprite = buyItemButtonSkin2FR;
        buyItem3Button.image.overrideSprite = buyItemButtonSkin2FR;

        chooseItem1Button.image.overrideSprite = chooseItemButtonSkin2FR;
        chooseItem3Button.image.overrideSprite = chooseItemButtonSkin2FR;
        chooseItem4Button.image.overrideSprite = chooseItemButtonSkin2FR;

        //achatBronze.color = Color.red;
        //achatBronze.font = basicFont;

        //achatArgent.color = Color.red;
        //achatArgent.font = basicFont;

        //achatOr.color = Color.red;
        //achatOr.font = basicFont;

        //recompenseBronze.color = Color.red;
        //recompenseBronze.font = arialFont;

        //recompenseArgent.color = Color.red;
        //recompenseArgent.font = arialFont;

        //recompenseOr.color = Color.red;
        //recompenseOr.font = arialFont;

        checkItemChoice1.gameObject.SetActive(false);
        checkItemChoice2.gameObject.SetActive(true);
        checkItemChoice3.gameObject.SetActive(false);
        checkItemChoice4.gameObject.SetActive(false);

        moneyImage.overrideSprite = moneyImageSkin4;

        closeTutorialButton.image.overrideSprite = closeTutorialButtonSkin2;

        moneyText.color = Color.red;
        highScoreText.color = Color.red;
        //infoItem1Text.color = Color.red;
        //infoItem2Text.color = Color.red;
        //infoItem3Text.color = Color.red;
        //infoItem4Text.color = Color.red;

        if (buyItem1Bool == 0)
        {
            priceItem1Text.font = basicFont;
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

            cadenas3.overrideSprite = cadenasOpened3;

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
        playButton.image.overrideSprite = playButtonSkin3FR;
        shopButton.image.overrideSprite = shopButtonSkin3;
        closeShopButton.image.overrideSprite = closeShopButtonSkin3;

        tutorialButton.image.overrideSprite = tutorialButtonSkin3FR;
        tutorialTextDown.color = Color.white;
        tutorialTextUp.color = Color.white;

        tutorialTextUp.font = basicFont;
        tutorialTextDown.font = basicFont;
        moneyText.font = basicFont;
        highScoreText.font = basicFont;

        tutorialTextDown.font = pixelFont;
        tutorialTextUp.font = pixelFont;
        moneyText.font = pixelFont;
        highScoreText.font = pixelFont;

        buyItem1Button.image.overrideSprite = buyItemButtonSkin3FR;
        buyItem2Button.image.overrideSprite = buyItemButtonSkin3FR;

        chooseItem1Button.image.overrideSprite = chooseItemButtonSkin3FR;
        chooseItem2Button.image.overrideSprite = chooseItemButtonSkin3FR;
        chooseItem4Button.image.overrideSprite = chooseItemButtonSkin3FR;

        //achatBronze.color = Color.white;
        //achatBronze.font = pixelFont;

        //achatArgent.color = Color.white;
        //achatArgent.font = pixelFont;

        //achatOr.color = Color.white;
        //achatOr.font = pixelFont;

        //recompenseBronze.color = Color.white;
        //recompenseBronze.font = arialFont;

        //recompenseArgent.color = Color.white;
        //recompenseArgent.font = arialFont;

        //recompenseOr.color = Color.white;
        //recompenseOr.font = arialFont;

        checkItemChoice1.gameObject.SetActive(false);
        checkItemChoice2.gameObject.SetActive(false);
        checkItemChoice3.gameObject.SetActive(true);
        checkItemChoice4.gameObject.SetActive(false);

        moneyImage.overrideSprite = moneyImageSkin3;

        closeTutorialButton.image.overrideSprite = closeTutorialButtonSkin3;

        moneyText.color = Color.white;
        highScoreText.color = Color.white;
        //infoItem1Text.color = Color.white;
        //infoItem2Text.color = Color.white;
        //infoItem3Text.color = Color.white;
        //infoItem4Text.color = Color.white;

        if (buyItem1Bool == 0)
        {
            priceItem1Text.font = pixelFont;
            priceItem1Text.color = Color.white;
        }

        if (buyItem2Bool == 0)
        {
            priceItem2Text.font = pixelFont;
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
        playButton.image.overrideSprite = playButtonSkin4FR;
        shopButton.image.overrideSprite = shopButonSkin4;
        closeShopButton.image.overrideSprite = closeShopButtonSkin4;

        tutorialButton.image.overrideSprite = tutorialButtonSkin4FR;
        tutorialTextUp.color = Color.white;
        tutorialTextDown.color = Color.white;

        tutorialTextDown.font = basicFont;
        tutorialTextUp.font = basicFont;
        moneyText.font = basicFont;
        highScoreText.font = basicFont;

        buyItem1Button.image.overrideSprite = buyItemButtonSkin4FR;
        buyItem2Button.image.overrideSprite = buyItemButtonSkin4FR;
        buyItem3Button.image.overrideSprite = buyItemButtonSkin4FR;

        chooseItem1Button.image.overrideSprite = chooseItemButtonSkin4FR;
        chooseItem2Button.image.overrideSprite = chooseItemButtonSkin4FR;
        chooseItem3Button.image.overrideSprite = chooseItemButtonSkin4FR;

        //achatBronze.color = Color.white;
        //achatBronze.font = basicFont;

        //achatArgent.color = Color.white;
        //achatArgent.font = basicFont;

        //achatOr.color = Color.white;
        //achatOr.font = basicFont;

        //recompenseBronze.color = Color.white;
        //recompenseBronze.font = arialFont;

        //recompenseArgent.color = Color.white;
        //recompenseArgent.font = arialFont;

        //recompenseOr.color = Color.white;
        //recompenseOr.font = arialFont;

        checkItemChoice1.gameObject.SetActive(false);
        checkItemChoice2.gameObject.SetActive(false);
        checkItemChoice3.gameObject.SetActive(false);
        checkItemChoice4.gameObject.SetActive(true);

        moneyImage.overrideSprite = moneyImageSkin4;

        closeTutorialButton.image.overrideSprite = closeTutorialButtonSkin4; 

        moneyText.color = Color.white;
        highScoreText.color = Color.white;
        //infoItem1Text.color = Color.white;
        //infoItem2Text.color = Color.white;
        //infoItem3Text.color = Color.white;
        //infoItem4Text.color = Color.white;

        if (buyItem1Bool == 0)
        {
            priceItem1Text.font = basicFont;
            priceItem1Text.color = Color.white;
        }

        if (buyItem2Bool == 0)
        {
            priceItem2Text.font = basicFont;
            priceItem2Text.color = Color.white;
        }

        if (buyItem3Bool == 0)
        {
            priceItem3Text.color = Color.white;
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

    // BRONZE

    public void ValidationAchatBronze()
    {
        confirmerAchatBronzePanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void AccepterAcheterBronze()
    {
        currentMoney = currentMoney + 500;
        thanksBronzePanel.SetActive(true);
        confirmerAchatBronzePanel.SetActive(false);
    }

    public void RefuserAcheterBronze()
    {
        confirmerAchatBronzePanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void RetourBoutique()
    {
        shopPanel.SetActive(true);
        thanksBronzePanel.SetActive(false);
        thanksArgentPanel.SetActive(false);
        thanksOrPanel.SetActive(false);
    }

    // ARGENT

    public void ValidationAchatArgent()
    {
        
        ConfirmerAchatArgentPanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void AccepterAcheterArgent()
    {
        currentMoney = PlayerPrefs.GetInt("currentMoney");
        currentMoney = currentMoney + 1700;
        PlayerPrefs.SetInt("currentMoney", currentMoney);
        thanksArgentPanel.SetActive(true);
        ConfirmerAchatArgentPanel.SetActive(false);
    }

    public void RefuserAcheterArgent()
    {
        ConfirmerAchatArgentPanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    // OR

    public void ValidationAchatOr()
    {     
        ConfirmerAchatOrPanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void AccepterAcheterOr()
    {
        currentMoney = currentMoney + 4800;
        thanksOrPanel.SetActive(true);
        ConfirmerAchatOrPanel.SetActive(false);
    }

    public void RefuserAcheterOr()
    {
        ConfirmerAchatOrPanel.SetActive(false);
        shopPanel.SetActive(true);
    }


    public void FermerThanksPanelBronze()
    {
        confirmerAchatBronzePanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void FermerThanksPanelArgent()
    {
        ConfirmerAchatArgentPanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void FermerThanksPanelOr()
    {
        ConfirmerAchatOrPanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void AddMoney () {

        currentMoney += 1;
    }

    public int GetMoney () {
        currentMoney = PlayerPrefs.GetInt("currentMoney");
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
