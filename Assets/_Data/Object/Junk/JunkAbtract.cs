using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JunkAbtract : MyMonoBehaviour
{
     [SerializeField] protected JunkCtrl junkCtrl;
    public JunkCtrl JunkCrtl {get => this.junkCtrl;}
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCtrl();
    }
    protected virtual void LoadCtrl()
    {
        if (this.junkCtrl != null ) return;
        junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        Debug.Log(transform.name + ": Load JunkCtrl", gameObject);
    }
}
