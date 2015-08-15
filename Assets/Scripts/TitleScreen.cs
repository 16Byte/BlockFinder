using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

    public bool isStartDemo = false;
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
        if (isStartDemo)
        {
            Application.LoadLevel("Level1");
        }
        if (isCloseGame)
        {
            Debug.Log("Closing Game");
            Application.Quit();
        }
    }

}
