using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JunkRandom : MyMonoBehaviour
{
    [SerializeField] protected JunkSpawnerCtrl junkSpawnerCtrl;
    [SerializeField] protected float randomDelay = 2f;
    [SerializeField] protected float randomTimer;
    [SerializeField] protected int randomLimit = 10;
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
        //this.SpawningJunk();
    }
    protected virtual void FixedUpdate()
    {
        this.SpawningJunk();
    }
    protected virtual void SpawningJunk()
    {
        if(RandomReachLimit()) return;
        this.randomTimer += Time.fixedDeltaTime;
        if(this.randomTimer < this.randomDelay) return;
        this.randomTimer = 0;
        Vector3 pos = this.junkSpawnerCtrl.JunkSpawnPoint.GetRandom().position;
        Quaternion rot = transform.rotation;
        Transform prefab = this.junkSpawnerCtrl.JunkSpawner.RandomPrefab();
        Transform obj = this.junkSpawnerCtrl.JunkSpawner.Spawn(prefab,pos,rot);
        obj.gameObject.SetActive(true);
       // Invoke(nameof(SpawningJunk),1f);
    }

    protected virtual bool RandomReachLimit()
    {
        int currentJunk = this.junkSpawnerCtrl.JunkSpawner.SpawnedCount();
        return currentJunk >= randomLimit;
    }
}
