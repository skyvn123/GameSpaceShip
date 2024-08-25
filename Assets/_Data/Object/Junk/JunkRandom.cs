using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : MyMonoBehaviour
{
    [SerializeField] protected JunkSpawnerCtrl junkSpawnerCtrl;
       protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpwanerCrtl();
    }
    protected virtual void LoadJunkSpwanerCrtl()
    {
        if (this.junkSpawnerCtrl != null ) return;
        junkSpawnerCtrl = GetComponent<JunkSpawnerCtrl>();
        Debug.Log(transform.name + ": Load JunkCtrl", gameObject);
    }

    protected override void Start()
    {
        base.Start();
        this.SpawningJunk();
    }
    protected virtual void SpawningJunk()
    {
        Vector3 pos = this.junkSpawnerCtrl.JunkSpawnPoint.GetRandom().position;
        Quaternion rot = transform.rotation;
        Transform obj = this.junkSpawnerCtrl.JunkSpawner.Spawn(JunkSpawner.junk_1,pos,rot);
        obj.gameObject.SetActive(true);
        Invoke(nameof(SpawningJunk),1f);
    }
}
