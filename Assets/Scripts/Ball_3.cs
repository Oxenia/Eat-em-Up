using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_3 : BallBehavoir //INHERITANCE
{
    public override void SpecialAbility() // POLYMORPHISM
    {
        spawnMangerScript.movementDirection = "right";
    }
}
