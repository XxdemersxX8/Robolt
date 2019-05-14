using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeKiller : MonoBehaviour
{
   public GameObject CanUI;
   public GameObject HideText;
   public GameObject HideText2;
    // Killing the player if he touch a spike
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            //Resetting the score to zero
            MyGUI.Score = 0;
            //Destroy the player model
            Destroy(gameObject);

            //Hide unwanted text.S
            HideText.SetActive(false);
            HideText2.SetActive(false);
            CanUI.SetActive(true);
            

        }
    }
}