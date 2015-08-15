﻿using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Death...");
            ResetGame();
        }
    }

    void ResetGame()
    {
        int level = Application.loadedLevel;
        Application.LoadLevel(level);
    }

}
