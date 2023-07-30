using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("EndGame", 240.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndGame() {
        // ends game
        // cuts to end scene
    }
}
