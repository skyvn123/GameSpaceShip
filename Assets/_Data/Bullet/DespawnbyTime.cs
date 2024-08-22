using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnbyTime : Despawn
{
    [SerializeField] protected float Lifetime = 4f;
    protected override bool CanDespawn()
    {
        Lifetime -= Time.fixedDeltaTime;
        if (Lifetime > 0) return false;
        return true;
    }
}
