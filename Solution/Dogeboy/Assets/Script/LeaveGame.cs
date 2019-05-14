using System;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class LeaveGame : MonoBehaviour
    {

        public GameObject canUI;
        public GameObject HideText1;
        public GameObject HideText2;

    private Boolean showing = false;
    // Giving the player the option to leave the game as they wish.
    private void Update()
    {
        //When the escape key is pressed, the pause menu is shown.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (showing == false)
            {
                showing = true;
                canUI.SetActive(true);
                HideText1.SetActive(false);
                HideText2.SetActive(false);
            }
            //If the menu is already present on screen, pressing once more will remove it.
            else if(showing==true)
            {
                showing = false;
                canUI.SetActive(false);
                HideText1.SetActive(false);
                HideText2.SetActive(false);
            }

        }

    }
}
   
        
    


