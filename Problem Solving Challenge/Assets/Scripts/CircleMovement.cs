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
        Vector2 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = transform.position;
        Vector2 direction = (mousePos - pos);
        rigidBody2D.velocity = speed * direction.normalized;
    }
}
