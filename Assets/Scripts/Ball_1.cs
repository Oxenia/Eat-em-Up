using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_1 : BallBehavoir //INHERITANCE
{
    public override void SpecialAbility() // POLYMORPHISM
    {
        spawnMangerScript.movementDirection = "back";
    }
}
