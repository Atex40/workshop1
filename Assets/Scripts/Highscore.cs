using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

	public Text score;
	public Text highscore;

	void Start () 
	{
		highscore.text = PlayerPrefs.GetInt("Highscore",0).ToString();
	}
	
	void Update () 
	{
		int number = Random.Range(1, 7);
		score.text = number.ToString();

		if (number > PlayerPrefs.GetInt("Highscore", 0))
		{
			PlayerPrefs.SetInt("Highscore", number);
			highscore.text = number.ToString();
		}
	}
}
