using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{

    [SerializeField] protected float bulletspeed = 15f;

    private void FixedUpdate()
    {
        transform.parent.Translate(bulletspeed * Time.deltaTime * transform.parent.up, Space.World);
    }
}
