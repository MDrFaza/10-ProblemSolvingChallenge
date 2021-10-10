using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;
 
    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float initialForceX;
    public float initialForceY;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        PushBall();
    }

    void PushBall()
    {
        rigidBody2D.AddForce(new Vector2(initialForceX, initialForceY));
    }
}
