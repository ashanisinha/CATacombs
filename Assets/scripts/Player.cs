using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3.0f;
    Animator anim;
    SpriteRenderer sp;
    public bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        sp.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isWalking", false);
        

        if(Input.GetKey(KeyCode.LeftArrow)) { // for each movement, create a vector 3
            transform.Translate(-speed * Time.deltaTime , 0, 0);
            anim.SetBool("isWalking", true);
            sp.flipX = true;
        }

        if(Input.GetKey(KeyCode.RightArrow)) { // for each movement, create a vector 3
            transform.Translate(speed * Time.deltaTime, 0, 0);
            anim.SetBool("isWalking", true);
            sp.flipX = false;
        } 
        if(Input.GetKey(KeyCode.UpArrow)) { // for each movement, create a vector 3
            transform.Translate(0, speed * Time.deltaTime, 0);
            anim.SetBool("isWalking", true);
        } 

        if(Input.GetKey(KeyCode.DownArrow)) { // for each movement, create a vector 3
            transform.Translate(0, -speed * Time.deltaTime, 0);
            anim.SetBool("isWalking", true);
        } 
        

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Wall") {
        
        if(Input.GetKey(KeyCode.LeftArrow)) { // for each movement, create a vector 3
            //transform.Translate(speed * Time.deltaTime , 0, 0);
            transform.Translate(0, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) { // for each movement, create a vector 3
            //transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.Translate(0, 0, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow)) { // for each movement, create a vector 3
           // transform.Translate(0, -speed * Time.deltaTime, 0);
           transform.Translate(0, 0, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)) { // for each movement, create a vector 3
           // transform.Translate(0, speed * Time.deltaTime, 0);
           transform.Translate(0, 0, 0);
        }
        
        }


        if (collision.gameObject.tag == "Key") {
            hasKey = true;
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.tag == "Gate" && hasKey) {
            Destroy(collision.gameObject);
            
        }

    }


    
}
