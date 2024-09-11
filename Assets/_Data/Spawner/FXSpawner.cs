using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    protected static FXSpawner instance;
    public static FXSpawner Instance => instance;
    public static string smoke_1 = "Smoke_1";
    public static string impact_1 ="Impact_1";
    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log("Only 1 FXSpawner allow");
        FXSpawner.instance = this;
    }
}
