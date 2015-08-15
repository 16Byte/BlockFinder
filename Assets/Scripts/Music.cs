using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

}
