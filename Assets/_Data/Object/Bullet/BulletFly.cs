using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BulletFly : ObjectFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.speed = 10f;
        this.direction = Vector3.up;
    }
}
