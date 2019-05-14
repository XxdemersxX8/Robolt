using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyGUI : MonoBehaviour {

    public static int Score = 0;
    public static string endGame;


    private GUIStyle guiStyle = new GUIStyle();
    


    // GUI to show the Score
    private void OnGUI()
    {
        //Adjust the font size and color of words to make it visible.
        guiStyle.fontSize = 30;
        GUI.color = Color.black;
        GUI.Label(new Rect(30, 20, 100, 75), "Score: " + Score.ToString(), guiStyle);

    }






    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
