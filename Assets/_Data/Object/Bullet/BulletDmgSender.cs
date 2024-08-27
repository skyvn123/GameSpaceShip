using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDmgSender : DamageSender
{
    [SerializeField] protected BulletCrtl bulletCrtl;
    public BulletCrtl BulletCrtl {get => this.bulletCrtl;}
    protected override void LoadComponents()
    { 
        base.LoadComponents();
        this.LoadBulletCrtl();
    }
    protected virtual void LoadBulletCrtl()
    {
        if (this.bulletCrtl != null ) return;
        bulletCrtl = transform.parent.GetComponent<BulletCrtl>();
        Debug.Log(transform.name + ": Load BulletCrtl", gameObject);
    }
    protected override void Destroythis()
    {
        this.BulletCrtl.BulletDespawn.DespawnObject();
    }

}
