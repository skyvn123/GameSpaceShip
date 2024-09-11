using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ObjectFly : MyMonoBehaviour
{

    [SerializeField]protected float speed = 1f;
    [SerializeField]protected Vector3 direction = Vector3.right;
    // private void FixedUpdate()
    // {
    //    transform.parent.Translate(speed * Time.deltaTime * transform.parent.up, Space.World);
    // }
    protected virtual void Update()
    {
        transform.parent.Translate(this.speed * Time.deltaTime * this.direction);
    }
}
