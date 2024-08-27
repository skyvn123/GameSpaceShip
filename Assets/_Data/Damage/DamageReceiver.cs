using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class DamageReceiver : MyMonoBehaviour
{
    [Header("Damage Receiver")]
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected int hp = 1;
    [SerializeField] protected int hpMax = 10;
    [SerializeField] protected bool isDead;

    protected override void OnEnable()
    {
        base.OnEnable();
        this.Reborn();
    }

    protected virtual void Reborn()
    {
        this.hp = this.hpMax;
        isDead = false;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }

    protected virtual void LoadCollider()
    {
        if(sphereCollider !=null) return;
        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.radius = 0.2f;
    }

    public virtual void Add(int add)
    {
        this.hp += add;
        if(this.hp > this.hpMax) this.hp = this.hpMax;
    }

    public virtual void Deduct(int deduct)
    {
        if(this.isDead) return;
        this.hp -= deduct;
        if(this.hp<0) this.hp = 0;
        this.CheckIsDead();
    }

    protected virtual void CheckIsDead()
    {
        if (!this.IsDead()) return;
        this.isDead = true;
        this.OnDead();
    }
    protected virtual bool IsDead()
    {
        return this.hp <= 0;
    }

    protected virtual void OnDead()
    {
        //for override
    }
}
