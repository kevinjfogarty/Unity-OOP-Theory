using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : Vehicle
{
    [SerializeField] int maxAltitude = 10;
    [SerializeField] int minAltitude = 0;

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    void goDown()
    {
        if (transform.position.y > minAltitude) transform.Translate(Vector3.down * speed * Time.deltaTime);
        else transform.position.Set(transform.position.x, minAltitude, transform.position.z);
    }

    void goUp()
    {
        if (transform.position.y < maxAltitude) transform.Translate(Vector3.up * speed * Time.deltaTime);
        else transform.position.Set(transform.position.x, maxAltitude, transform.position.z);
    }
    override protected void Turn(string direction)
    {
        //Helicopter can rotate in place
        switch (direction.ToLower())
        {
            case "left":
                transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
                break;
            case "right":
                transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
                break;
        }
    }

    protected override void Move()
    {
        //Helicopter can also go up/down
        if (Input.GetKey(KeyCode.Q)) goDown();
        if (Input.GetKey(KeyCode.E)) goUp();
        base.Move();
    }
}
