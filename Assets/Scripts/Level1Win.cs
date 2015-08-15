using UnityEngine;
using System.Collections;

public class Level1Win : MonoBehaviour {

    public bool isLevel1 = false;
    public bool isLevel2 = false;
    public bool isLevel3 = false;
    public bool isLevel4 = false;
    public bool isLevel5 = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Win!");
            NextLevel();
        }
    }

    void NextLevel()
    {
        if(isLevel1)
        Application.LoadLevel("Level2");
        if (isLevel2)
        Application.LoadLevel("Level3");
        if (isLevel3)
            Application.LoadLevel("Level4");
        if (isLevel4)
            Application.LoadLevel("DemoEnd");
        if (isLevel5)
            Application.LoadLevel("Level6");
    }
}
