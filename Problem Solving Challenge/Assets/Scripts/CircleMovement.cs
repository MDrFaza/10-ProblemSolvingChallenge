using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;
 
    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
 
        if (Input.GetKey("up"))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey("down"))
        {
            velocity.y = -speed;
        }
        else if(Input.GetKey("right"))
        {
            velocity.x = speed;
        }
        else if(Input.GetKey("left"))
        {
            velocity.x = -speed;
        }
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }

        rigidBody2D.velocity = velocity;
    }
}
