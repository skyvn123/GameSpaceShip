
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    protected static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance;}
    public static string junk_1 = "junk_1";
    public static string junk_2 = "junk_2";
    public static string junk_3 = "junk_3";
    public static string junk_4 = "junk_4";

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log("Only 1 ButlletSpawner allow");
        JunkSpawner.instance = this;
    }
}
