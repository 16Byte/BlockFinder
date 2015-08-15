using UnityEngine;
using System.Collections;

public class Tutorial1stLevel : MonoBehaviour {

    public bool isDismiss = false;

    public GameObject Paragraph;
    public GameObject DismissButton;

    void Start()
    {
        Time.timeScale = 0.0f;
        if (isDismiss)
            GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseDown()
    {
        if(isDismiss)
        Paragraph.SetActive(false);
        DismissButton.SetActive(false);
        Time.timeScale = 1.0f;
    }

    void OnMouseEnter()
    {
        if(isDismiss)
        GetComponent<Renderer>().material.color = Color.grey;
    }

    void OnMouseExit()
    {
        if(isDismiss)
        GetComponent<Renderer>().material.color = Color.white;
    }

}
