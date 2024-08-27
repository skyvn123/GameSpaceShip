using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MyMonoBehaviour
{
    [SerializeField] protected int damage =1;

    public virtual void Send(Transform obj)
    {
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if(damageReceiver == null) return;
        this.Send(damageReceiver);
        this.Destroythis();
    }

    protected virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
    }

    protected virtual void Destroythis()
    {
        Destroy(this.transform.parent.gameObject);
    }
}
