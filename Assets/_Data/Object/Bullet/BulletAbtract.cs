using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAbstract : MyMonoBehaviour
{
    [SerializeField] protected BulletCrtl bulletCtrl;
    public BulletCrtl BulletCrtl {get => this.bulletCtrl;}
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCtrl();
    }
    protected virtual void LoadCtrl()
    {
        if (this.bulletCtrl != null ) return;
        bulletCtrl = transform.parent.GetComponent<BulletCrtl>();
        Debug.Log(transform.name + ": Load BulletCrtl", gameObject);
    }
}
