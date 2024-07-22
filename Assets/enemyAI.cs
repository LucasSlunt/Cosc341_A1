using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    [SerializeField]float movementDistance;
    [SerializeField] float speed;
    bool movementDirection; //true = left, false = right
    float leftSide;
    float rightSide;
    // Start is called before the first frame update
    void Start()
    {
        movementDistance = 10;
        speed = 2;
    }

    void Awake()
    {
        leftSide = transform.position.x - movementDistance;
        rightSide = transform.position.x + movementDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (movementDirection)//if moving left
        {
            if(transform.position.x > leftSide)
            {
                transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                movementDirection = false; //make it move right
            }
        }
        else //if moving right, do the opposite
        {
            if (transform.position.x < rightSide)
            {
                transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                movementDirection = true; //make it move left
            }
        }   
    }
}
