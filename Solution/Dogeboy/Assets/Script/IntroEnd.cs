using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroEnd : MonoBehaviour {

    // To automatically switch from the tutorial to the main level
    void OnCollisionEnter2D(Collision2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            //Resets the score for the next level
            MyGUI.Score = 0;
            //Load the next level
            SceneManager.LoadScene(2);
        }
    }


}
