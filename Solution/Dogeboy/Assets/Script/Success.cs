using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Success : MonoBehaviour {

    public GameObject CanUI;
    public GameObject HideText1;
    public GameObject HideText2;
    // Restarting the level if the endzone at the bottom has been touch

    public void Start () {
        //Hide the canvas, buttons and the text
        CanUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Show Canvas
            CanUI.SetActive(true);
            //Hide Selected Texts
            HideText1.SetActive(false);
            HideText2.SetActive(false);
        }
    }

    public void QuitGame()
    {

        //Terminate the application
        Application.Quit();
    }
    public void Restart()
    {
        //Restart the current level
        MyGUI.Score = 0;
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }


    public void MainMenu()
    {
        //Return to the Main Menu scene
        SceneManager.LoadScene(0);
    }

    public void GetCredits()
    {
        //Go to the Credits scene
        SceneManager.LoadScene(3);
    }

}
