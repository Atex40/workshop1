using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomyManager : MonoBehaviour {

    private int currentMoney;
    public int addMoney;
    public Text money;
    private bool bi1 = false;
    private bool bi2 = false;
    private bool bi3 = false;

	// Use this for initialization
	void Start () {
        currentMoney = 0;
	}
	
	// Update is called once per frame
	void Update () {

        money.text = currentMoney.ToString();
        if (Input.GetKeyDown("c"))
        {
            currentMoney = currentMoney + 250;
            Debug.Log("Plus de cash");
        }

	}


    public void EarnMoney()
    {
        currentMoney = currentMoney + addMoney;
    }

    public void BuyItem1()
    {
        if (currentMoney > 500 && bi1 == false)
        {
            currentMoney = currentMoney - 500;
            bi1 = true;
            Debug.Log("Item 1 acheté");
        }
        else
        {
            Debug.Log("Item 1 ne peut etre acheté");
        }
    }

    public void BuyItem2()
    {
        if (currentMoney > 1000 && bi2 == false)
        {
            currentMoney = currentMoney - 1000;
            bi2 = true;
            Debug.Log("Item 2 acheté");
        }
        else
        {
        Debug.Log("Item 2 ne peut etre acheté");
        }
    }

    public void BuyItem3()
    {
        if (currentMoney > 2000 && bi3 == false)
        {
            currentMoney = currentMoney - 2000;
            bi3 = true;
            Debug.Log("Item 3 acheté");
        }
        else
        {
        Debug.Log("Item 3 ne peut etre acheté");
        }
    }
}
