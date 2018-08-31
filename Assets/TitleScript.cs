using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {
    private GUIStyle buttonstyle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, Screen.height / 2 + 100, Screen.width - 10, 200));
        if (GUILayout.Button("New Game"))
        {
            SceneManager.LoadScene("Gameplayscene");
        }
        if(GUILayout.Button("High Score"))
        {
            Debug.Log("you implement high score scr");
        }
        if(GUILayout.Button("Exit"))
        {
            Application.Quit();
            Debug.Log("Application.Quit() only works int build, not editor");
        }
        GUILayout.EndArea();
    }
   
}
