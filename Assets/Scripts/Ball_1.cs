using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_1 : BallBehavoir
{
    public override void SpecialAbility()
    {
        spawnMangerScript.movementDirection = "back";
    }
}
