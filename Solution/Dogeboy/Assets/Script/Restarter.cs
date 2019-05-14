using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {

        public GameObject CanUI;
        public GameObject HideText1;
        public GameObject HideText2;
        // Restarting the level if the endzone at the bottom has been touch
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                //Destroy the object colliding & reset score
                Destroy(gameObject);
                MyGUI.Score = 0;
                
                // Show Canvas and failure message
                CanUI.SetActive(true);
                HideText1.SetActive(false);
                HideText2.SetActive(false);
            }
        }
    }
}


