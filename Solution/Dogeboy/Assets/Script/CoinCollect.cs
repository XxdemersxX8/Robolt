using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {

    public int coinvalue = 1;
    public AudioSource audio;
    // Collect the coins and increment the score

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            //Increment Score
            MyGUI.Score += coinvalue;
            //Destroy the coin
            Destroy(collision.gameObject);
           //Play the sound effect
            audio.Play();
        }
    }
}
