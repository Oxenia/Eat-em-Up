using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_4 : BallBehavoir //INHERITANCE
{
    public override void SpecialAbility() // POLYMORPHISM
    {
        spawnMangerScript.movementDirection = "left";
    }
}
