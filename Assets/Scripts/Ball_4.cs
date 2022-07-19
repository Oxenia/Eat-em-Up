using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_4 : BallBehavoir
{
    public override void SpecialAbility()
    {
        spawnMangerScript.movementDirection = "left";
    }
}
