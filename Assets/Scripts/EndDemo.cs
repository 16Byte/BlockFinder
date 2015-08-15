using UnityEngine;
using System.Collections;

public class EndDemo : MonoBehaviour {

    public bool isTitleScreen = false;
    public bool isCloseGame = false;


    void Awake()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseEnter()
    {
     
            GetComponent<Renderer>().material.color = Color.grey;
    }

    void OnMouseExit()
    {
     
            GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseUp()
    {
        if (isTitleScreen)
        {
            Application.LoadLevel("TitleScreen");
        }
        if (isCloseGame)
        {
            Debug.Log("Closing Game...");
            Application.Quit();
        }
    }
}
