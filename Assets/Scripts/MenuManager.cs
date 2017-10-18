using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject shopWindow;
    public GameObject playButton;
    public GameObject shopButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToGame()
    {
        SceneManager.LoadScene("ScenePierreCube");
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

    public void QuitApp()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("SceneCodeUIPierre");
    }

}

