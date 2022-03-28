using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : Vehicle // INHERITANCE
{
    new void Start()
    {
        base.Start();
    }

    override protected void Turn(string direction) // POLYMORPHISM
    {
        Debug.Log("Train cannot turn");
    }
}
