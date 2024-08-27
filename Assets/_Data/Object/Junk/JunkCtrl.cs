using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : MyMonoBehaviour
{
[SerializeField] protected Transform model;
public Transform Model {get => this.model;}
[SerializeField] protected JunkDespawn junkDespawn;
public JunkDespawn JunkDespawn {get => this.junkDespawn;}
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkDespawn();
        this.LoadModel();
    }
    protected virtual void LoadJunkDespawn()
    {
        if (this.junkDespawn != null ) return;
        junkDespawn = GetComponentInChildren<JunkDespawn>();
        Debug.Log(transform.name + ": Load JunkDespawn", gameObject);
    }
    protected virtual void LoadModel()
    {
        if (this.model != null ) return;
        model = transform.Find("Model");
        Debug.Log(transform.name + ": Load Model", gameObject);
    }
}
