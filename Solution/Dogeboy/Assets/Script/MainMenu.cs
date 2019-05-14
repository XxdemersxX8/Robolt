using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject cred;

    //Manage the Mainmenu and It's button
	public void startGame()
    {
        //Load the tutorial level
        SceneManager.LoadScene(1);
    }


    public void QuitGame()
    {
        //Terminate the application
        Application.Quit();
    }

    
}
