using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) { // for each movement, create a vector 3
            transform.Translate(-speed * Time.deltaTime , 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) { // for each movement, create a vector 3
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow)) { // for each movement, create a vector 3
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)) { // for each movement, create a vector 3
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Wall") {
        
        if(Input.GetKey(KeyCode.LeftArrow)) { // for each movement, create a vector 3
            transform.Translate(speed * Time.deltaTime , 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) { // for each movement, create a vector 3
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow)) { // for each movement, create a vector 3
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)) { // for each movement, create a vector 3
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        
        }
    }
}
