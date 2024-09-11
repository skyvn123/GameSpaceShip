using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;

public class JunkCtrl : MyMonoBehaviour
{
[SerializeField] protected Transform model;
public Transform Model {get => this.model;}
[SerializeField] protected JunkDespawn junkDespawn;
public JunkDespawn JunkDespawn {get => this.junkDespawn;}
[SerializeField] protected JunkSO junkSO;
public JunkSO JunkSO => junkSO;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkDespawn();
        this.LoadModel();
        this.LoadJunkSO();
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

    protected virtual void LoadJunkSO()
    {
        if (this.junkSO != null ) return;
        string respath = "Junk/" + transform.name;
        this.junkSO = Resources.Load<JunkSO>(respath);
        Debug.LogWarning(transform.name + ": Load JunkSO" + respath, gameObject);
    }
}
