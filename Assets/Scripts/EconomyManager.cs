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

    

    // ELEMENTS UI
    public Button quitButton;
    public Button playButton;
    public Button shopButton;
    public GameObject chooseItem1Button;
    public GameObject chooseItem2Button;
    public GameObject chooseItem3Button;
    public GameObject chooseItem4Button;
    public Image moneyImage;
    public Text hightScoreText;
    public Text moneyText;
    public GameObject buyItem1Button;
    public GameObject buyItem2Button;
    public GameObject buyItem3Button;
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
    public Sprite moneyImageSkin1;
    public Material skyboxSkin1;
    public Sprite buyItem2ButtonSkin1;
    public Sprite buyItem3ButtonSkin1;   
    public Sprite chooseItem2ButtonSkin1;
    public Sprite chooseItem3ButtonSkin1;
    public Sprite chooseItem4ButtonSkin1;

    // SKIN 2 : ESPACE ROUGE
    public Sprite quitButtonSkin2;
    public Sprite playButtonSkin2;
    public Sprite shopButtonSkin2;
    public Sprite moneImageSkin2;
    public Material skyboxSkin2;
    public Sprite buyItem1ButtonSkin2;
    public Sprite buyItem3ButtonSkin2;
    public Sprite chooseItem1ButtonSkin2;
    public Sprite chooseItem3ButtonSkin2;
    public Sprite chooseItem4ButtonSkin2;

    // SKIN 3 : ARCADE NOIR ET BLANC
    public Sprite quitButtonSkin3;
    public Sprite playButtonSkin3;
    public Sprite shopButtonSkin3;
    public Sprite moneyImageSkin3;
    public Material skyboxSkin3;
    public Sprite buyItem1ButtonSkin3;
    public Sprite buyItem2ButtonSkin3;
    public Sprite chooseItem1ButtonSkin3;
    public Sprite chooseItem2ButtonSkin3;
    public Sprite chooseItem4ButtonSkin3;

    // SKIN 4 : PAR DEFAUT
    public Sprite quitButtonSkin4;
    public Sprite playButtonSkin4;
    public Sprite shopButonSkin4;
    public Sprite moneyImageSkin4;
    public Material skyboxSkin4;
    public Sprite buyItem1ButtonSkin4;
    public Sprite buyItem2ButtonSkin4;
    public Sprite buyItem3ButtonSkin4;
    public Sprite chooseItem1ButtonSkin4;
    public Sprite chooseItem2ButtonSkin4;
    public Sprite chooseItem3ButtonSkin4;


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

        buyItem1Button.SetActive(true);
        currentMoney = PlayerPrefs.GetInt("currentMoney");
        activateItem1Bool = PlayerPrefs.GetInt("boolean1");
        activateItem2Bool = PlayerPrefs.GetInt("boolean2");
        activateItem3Bool = PlayerPrefs.GetInt("boolean3");
        buyItem1Bool = PlayerPrefs.GetInt("EspaceVert");
        buyItem2Bool = PlayerPrefs.GetInt("EspaceRouge");

        if (buyItem1Bool == 1) // SI LE SKIN 1 EST ACHETE
        {
            activateItem1Bool = 1;
            PlayerPrefs.SetInt("boolean1", activateItem1Bool);
            Destroy(buyItem1Button);
            chooseItem1Button.SetActive(true);
            
        }

        if (buyItem2Bool == 1) // SI LE SKIN 2 EST ACHETE
        {
            activateItem2Bool = 1;
            PlayerPrefs.SetInt("boolean2", activateItem2Bool);
            Destroy(buyItem2Button);
            chooseItem2Button.SetActive(true);
            
        }

        if (buyItem3Bool == 1) // SI LE SKIN 3 EST ACHETE
        {
            activateItem3Bool = 1;
            PlayerPrefs.SetInt("boolean2", activateItem3Bool);
            Destroy(buyItem3Button);
            chooseItem3Button.SetActive(true);
        }
        if (activateItem1Bool == 1) // SI LE SKIN 1 EST ACTIF
        {
            activateItem1Bool = 0;
            activateItem2Bool = 0;
            activateItem3Bool = 0;            
            PlayerPrefs.SetInt("boolean1", activateItem1Bool);
            RenderSettings.skybox = skyboxSkin1;
            quitButton.image.overrideSprite = quitButtonSkin1;
            playButton.image.overrideSprite = playButtonSkin1;
            shopButton.image.overrideSprite = shopButtonSkin1;
            moneyText.color = Color.green;
            hightScoreText.color = Color.green;
            moneyImage.sprite = moneyImageSkin1;
            chooseItem1Button.SetActive(false);

        }

        if (activateItem2Bool == 1) // SI LE SKIN 2 EST ACTIF
        {
            activateItem1Bool = 0;
            activateItem2Bool = 0;
            activateItem3Bool = 0;
            PlayerPrefs.SetInt("boolean2", activateItem2Bool);
            RenderSettings.skybox = skyboxSkin2;
            quitButton.image.overrideSprite = quitButtonSkin2;
            playButton.image.overrideSprite = playButtonSkin2;
            shopButton.image.overrideSprite = shopButtonSkin2;
            moneyText.color = Color.red;
            hightScoreText.color = Color.red;
            moneyImage.sprite = moneImageSkin2;
            chooseItem2Button.SetActive(false);
        }

        if (activateItem3Bool == 1) // SI LE SKIN 3 EST ACTIF
        {
            
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
            buyItem1Bool = 0;
            buyItem2Bool = 0;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean1", activateItem1Bool);
            PlayerPrefs.SetInt("boolean2", activateItem2Bool);
            PlayerPrefs.SetInt("boolean3", activateItem3Bool);
            PlayerPrefs.SetInt("EspaceVert", buyItem1Bool);
            PlayerPrefs.SetInt("EspaceRouge", buyItem2Bool);
            Debug.Log("jeu reinitialise");
        }

        AffichagePieces();


    }



    public void BuyItem1() // ACHETER OBJET ESPACE VERT
    {
        if (currentMoney >= 500)
        {
            buyItem1Bool = 1;
            PlayerPrefs.SetInt("EspaceVert", buyItem1Bool);
            Destroy(buyItem1Button);
            chooseItem1Button.SetActive(true);
            currentMoney = currentMoney - 500;        
            PlayerPrefs.SetInt("currentMoney", currentMoney);           
            Debug.Log("Item 1 acheté");
        }
       
        else
        {
            Debug.Log("Item 1 ne peut etre acheté");
        }
    }

    public void ChooseItem1() // CHOISIR OBJET ESPACE VERT
    {
            activateItem1Bool = 1;
            activateItem2Bool = 0;
            activateItem3Bool = 0;
            chooseItem1Button.SetActive(false);
            PlayerPrefs.SetInt("boolean1", activateItem1Bool);
            RenderSettings.skybox = skyboxSkin1;
            quitButton.image.overrideSprite = quitButtonSkin1;
            playButton.image.overrideSprite = playButtonSkin1;
            shopButton.image.overrideSprite = shopButtonSkin1;
            moneyText.color = Color.green;
            hightScoreText.color = Color.green;
            moneyImage.sprite = moneyImageSkin1;

        if (buyItem2Bool == 1)
        {
            chooseItem2Button.SetActive(true);
        }
            Debug.Log("Item 1 sélectionné");
    }

    public void BuyItem2() // ACHETER OBJET ESPACE ROUGE
    {
        if (currentMoney >= 1000)
        {            
            buyItem2Bool = 1;            
            PlayerPrefs.SetInt("EspaceRouge", buyItem2Bool);
            Destroy(buyItem2Button);
            chooseItem2Button.SetActive(true);
            currentMoney = currentMoney - 1000;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            Debug.Log("Item 2 acheté");
        }
        else
        {
        Debug.Log("Item 2 ne peut etre acheté");
        }
    }

    public void ChooseItem2() // CHOISIR OBJET ESPACE ROUGE
    {
        activateItem1Bool = 0;
        activateItem2Bool = 1;
        activateItem3Bool = 0;
        chooseItem2Button.SetActive(false);
        PlayerPrefs.SetInt("boolean2", activateItem2Bool);
        RenderSettings.skybox = skyboxSkin2;
        quitButton.image.overrideSprite = quitButtonSkin2;
        playButton.image.overrideSprite = playButtonSkin2;
        shopButton.image.overrideSprite = shopButtonSkin2;
        moneyText.color = Color.red;
        hightScoreText.color = Color.red;
        moneyImage.sprite = moneImageSkin2;

        if (buyItem1Bool == 1)
        {
            chooseItem1Button.SetActive(true);
        }

        Debug.Log("Item 2 sélectionné");
    }

    public void BuyItem3()
    {
        if (currentMoney >= 1500 && activateItem3Bool == 0)
        {
            currentMoney = currentMoney - 1500;
            activateItem3Bool = 1;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean3", activateItem3Bool);
            Destroy(buyItem3Button);
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

    public void AffichagePieces()
    {
        moneyText.text = currentMoney.ToString();
    }
}
