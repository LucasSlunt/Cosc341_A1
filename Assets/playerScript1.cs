using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D body;
    public float speed;
    public float jumpSpeed;
    public bool isInAir = false;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
        jumpSpeed = 6;
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal")* speed, body.velocity.y); //horizontal movement

        if (Input.GetKey(KeyCode.Space) && !isInAir) //jumping
        {
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
            isInAir = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) //detects collisions between the player and any other object
    {
        if (collision.gameObject.tag == "platform")
        {
            isInAir = false;
        }

    }

}
