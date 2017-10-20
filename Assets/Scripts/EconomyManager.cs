using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomyManager : MonoBehaviour {

    private int currentMoney = 0;
    public int addMoney;
    public Text money;
    private int bi1YES = 0;
    private int bi2YES = 0;
    private int bi3YES = 0;
    public GameObject buy1Button;
    public GameObject buy2Button;
    public GameObject buy3Button;

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
            currentMoney = currentMoney - 500;
            bi1YES = 1;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean1", bi1YES);
            Debug.Log("Item 1 acheté");
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
            Debug.Log("Item 2 acheté");
        }
        else
        {
        Debug.Log("Item 2 ne peut etre acheté");
        }
    }

    public void BuyItem3()
    {
        if (currentMoney >= 2000 && bi3YES == 0)
        {
            currentMoney = currentMoney - 2000;
            bi3YES = 1;
            PlayerPrefs.SetInt("currentMoney", currentMoney);
            PlayerPrefs.SetInt("boolean3", bi3YES);
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
