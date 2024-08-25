using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : MyMonoBehaviour
{
 [SerializeField] protected JunkSpawner junkSpawner;
 public JunkSpawner JunkSpawner {get => this.junkSpawner;}
  [SerializeField] protected JunkSpawnPoint junkSpawnPoint;
 public JunkSpawnPoint JunkSpawnPoint {get => this.junkSpawnPoint;}
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadJunkSpawnPoint();
    }
    protected virtual void LoadJunkSpawner()
    {
        if (this.junkSpawner != null ) return;
        junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ": Load JunkSpawner", gameObject);
    }

       protected virtual void LoadJunkSpawnPoint()
    {
        if (this.junkSpawnPoint != null ) return;
        junkSpawnPoint = Transform.FindObjectOfType<JunkSpawnPoint>();
        Debug.Log(transform.name + ": Load JunkSpawnPoint", gameObject);
    }
}
