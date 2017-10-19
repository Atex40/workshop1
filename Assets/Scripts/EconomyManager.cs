using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomyManager : MonoBehaviour {

    public int currentMoney;
    public int addMoney;
    public Text money;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        money.text = "$ " + currentMoney.ToString();

	}

    public void EarnMoney()
    {
        currentMoney = currentMoney + addMoney;
    }

    public void BuyItem1()
    {
        if (currentMoney > 500)
        {
            currentMoney = currentMoney - 500;
        }
    }

    public void BuyItem2()
    {
        if (currentMoney > 1000)
        {
            currentMoney = currentMoney - 1000;
        }
    }

    public void BuyItem3()
    {
        if (currentMoney > 2000)
        {
            currentMoney = currentMoney - 2000;
        }
    }
}
