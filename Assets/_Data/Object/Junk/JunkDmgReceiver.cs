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
        this.Reborn();
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
        this.OnDeadFX();
    }

    protected virtual void OnDeadFX()
    {
        string fxName = this.GetOnDeadFXName();
        Transform fxOnDead = FXSpawner.Instance.Spawn(FXSpawner.smoke_1,transform.position,transform.rotation);
        fxOnDead.gameObject.SetActive(true);
        Debug.Log(transform.name + "onDead create FX: "+ fxName);
    }

    protected virtual string GetOnDeadFXName()
    {
        return FXSpawner.smoke_1;
    }

    protected override void Reborn()
    {   
        this.hpMax = this.junkCtrl.JunkSO.hpMax;
        base.Reborn();
    }
}
