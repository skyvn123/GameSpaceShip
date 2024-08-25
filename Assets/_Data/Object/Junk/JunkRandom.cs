using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : MyMonoBehaviour
{
    [SerializeField] protected JunkCtrl junkCtrl;
       protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCrtl();
    }
    protected virtual void LoadJunkCrtl()
    {
        if (this.junkCtrl != null ) return;
        junkCtrl = GetComponent<JunkCtrl>();
        Debug.Log(transform.name + ": Load JunkCtrl", gameObject);
    }

    protected override void Start()
    {
        base.Start();
        this.SpawningJunk();
    }
    protected virtual void SpawningJunk()
    {
        Vector3 pos = this.junkCtrl.JunkSpawnPoint.GetRandom().position;
        Quaternion rot = transform.rotation;
        Transform obj = this.junkCtrl.JunkSpawner.Spawn(JunkSpawner.junk_1,pos,rot);
        obj.gameObject.SetActive(true);
        Invoke(nameof(SpawningJunk),1f);
    }
}
