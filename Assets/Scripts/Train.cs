using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : Vehicle
{
    new void Start()
    {
        base.Start();
    }

    override protected void Turn(string direction)
    {
        Debug.Log("Train cannot turn");
    }
}
