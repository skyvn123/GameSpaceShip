using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : MyMonoBehaviour
{
  [SerializeField] protected Transform model;
  public Transform Model {get => this.model;}
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }
    protected virtual void LoadModel()
    {
        if (this.model != null ) return;
        model = transform.Find("Model");
        Debug.Log(transform.name + ": Load Model", gameObject);
    }
}
