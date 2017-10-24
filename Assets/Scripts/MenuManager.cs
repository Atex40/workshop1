using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject shopWindow;
    public GameObject playButton;
    public GameObject shopButton;
    public GameObject tutorialCanvas;
    public GameObject shopCanvas;
 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToGame()
    {
        SceneManager.LoadScene("InGame");
    }

    public void OpenShop()
    {
        shopWindow.SetActive(true);
        playButton.SetActive(false);
        shopButton.SetActive(false);
    }

    public void CloseShop()
    {
        shopWindow.SetActive(false);
        playButton.SetActive(true);
        shopButton.SetActive(true);
    }

    public void OpenTutorialCanvas()
    {
        shopButton.gameObject.SetActive(false);
        tutorialCanvas.SetActive(true);        
        playButton.gameObject.SetActive(false);
        shopCanvas.SetActive(false);
        

    }

    public void CloseTutorialCanvas()
    {
        shopButton.gameObject.SetActive(true);
        tutorialCanvas.SetActive(false);
        playButton.gameObject.SetActive(true);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Quitter application");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("SceneLucas");
    }

}

