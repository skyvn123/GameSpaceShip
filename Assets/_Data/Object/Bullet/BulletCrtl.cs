using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCrtl : MyMonoBehaviour
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender {get => this.damageSender;}
    [SerializeField] protected BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn {get => this.bulletDespawn;}
    protected override void LoadComponents()
    { 
        base.LoadComponents();
        this.LoadDamageSender();
        this.LoadBulletDespawn();
    }
    protected virtual void LoadDamageSender()
    {
        if (this.damageSender != null ) return;
        damageSender = GetComponentInChildren<DamageSender>();
        Debug.Log(transform.name + ": Load DamageSender", gameObject);
    }
    protected virtual void LoadBulletDespawn()
    {
        if (this.bulletDespawn != null ) return;
        bulletDespawn = GetComponentInChildren<BulletDespawn>();
        Debug.Log(transform.name + ": Load BulletDespawn", gameObject);
    }
}
