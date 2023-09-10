using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baguette : MonoBehaviour
{
    int BaguetteCount = 5;
    int DropCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (DropCount > BaguetteCount) //checking if player already dropped 5 baguettes
            {
                Debug.Log("No more baguettes");
                //insert UI message
            }
            else
            {
                DropCount++;
                //Instantiate(BaguettePrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
