
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    protected static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance;}
    public static string Meteorite_1 = "Meteorite_1";
    public static string Meteorite_2 = "Meteorite_2";
    public static string Meteorite_3 = "Meteorite_3";
    
    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log("Only 1 ButlletSpawner allow");
        JunkSpawner.instance = this;
    }
}
