using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
                                    // Use this for initialization
    private Transform tf;

    public GameObject ropeRoot;
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        Vector2 velocity = new Vector2(0, 0);
        //L AND R
        if(Input.GetKey(KeyCode.A)){
            velocity.x = -speed;
        }else if (Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
        }

        if(Input.GetKey(KeyCode.W)){
            velocity.y = speed;

        }
        else if (Input.GetKey(KeyCode.S)){
            velocity.y = -speed;
        }


        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
    }
}
