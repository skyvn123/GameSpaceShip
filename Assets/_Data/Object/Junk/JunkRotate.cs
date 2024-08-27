using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbtract
{
    [SerializeField] protected float speed = 50f;
    protected virtual void FixedUpdate()
    {
        this.Rotating();
    }
    protected virtual void Rotating()
    {
        Vector3 eulers = new(0,0,1);
        this.JunkCrtl.Model.Rotate(this.speed * Time.fixedDeltaTime * eulers);
    }
}
