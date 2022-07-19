using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_2 : BallBehavoir
{
    public override void SpecialAbility()
    {
        spawnMangerScript.movementDirection = "forward";
    }
}
