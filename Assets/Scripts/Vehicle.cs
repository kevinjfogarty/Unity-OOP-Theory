using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] protected int speed = 10;
    [SerializeField] protected int turnSpeed;
    protected GameManager gameManager;

    protected void Start()
    {
        turnSpeed = speed * 3;
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager.isGameStarted())
        {
            Move();
        }
    }

    void goForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void goBackward()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    virtual protected void Turn(string direction)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) //vehicle needs to be moving to turn
        {
            switch (direction.ToLower()){
            case "left":
                transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
                break;
            case "right":
                transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
                break;
            }
        }
    }

    virtual protected void Move()
    {
        if (Input.GetKey(KeyCode.W)) goForward();
        if (Input.GetKey(KeyCode.S)) goBackward();
        if (Input.GetKey(KeyCode.A)) Turn("left");
        if (Input.GetKey(KeyCode.D)) Turn("right");
    }
}
