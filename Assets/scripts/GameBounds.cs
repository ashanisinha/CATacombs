using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBounds : MonoBehaviour
{
    // Update is called once per frame
    private Vector2 originalPosition;
    void Start () 
    {
        originalPosition = transform.position;
    }



    void Update()
    {
        // if out of bounds go back to original position
        if (transform.position.x > 4 || transform.position.x < -4 || transform.position.y > 4 || transform.position.y < -2) {
            transform.position = originalPosition;
        }
    }
}
