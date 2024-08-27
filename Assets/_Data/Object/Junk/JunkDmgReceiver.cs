using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDmgReceiver : DamageReceiver
{
    [SerializeField] protected JunkCtrl junkCtrl;
    public JunkCtrl BulletCrtl {get => this.junkCtrl;}
    protected override void LoadComponents()
    { 
        base.LoadComponents();
        this.LoadBulletCrtl();
    }
    protected virtual void LoadBulletCrtl()
    {
        if (this.junkCtrl != null ) return;
        junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        Debug.Log(transform.name + ": Load BulletCrtl", gameObject);
    }

    protected override void OnDead()
    {
        this.junkCtrl.JunkDespawn.DespawnObject();
    }
}
