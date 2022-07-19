using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_3 : BallBehavoir
{
    public override void SpecialAbility()
    {
        spawnMangerScript.movementDirection = "right";
    }
}
