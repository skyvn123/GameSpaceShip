using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MyMonoBehaviour
{
    [SerializeField] protected List<Transform> spawnPoints;
        protected override void LoadComponents()
    {
        this.LoadSpawnPoint();
    }
    protected virtual void LoadSpawnPoint()
    {
        if (this.spawnPoints.Count > 0 ) return;
        foreach(Transform spawnpoint in transform)
        {
            this.spawnPoints.Add(spawnpoint);
        }
    Debug.Log(transform.name + ": Load SpawnPoint",gameObject);
    }
    public virtual Transform GetRandom()
    {
        int random = Random.Range(0,this.spawnPoints.Count);
        return this.spawnPoints[random];
    }
}
