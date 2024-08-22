using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawer
{
    protected static BulletSpawner instance;
    public static BulletSpawner Instance { get => instance;}
    public static string bullet_1 = "Bullet_1";
    public static string bullet_2 = "Bullet_2";
    public static string bullet_3 = "Bullet_3";
    public static string bullet_4 = "Bullet_4";

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log("Only 1 ButlletSpawner allow");
        BulletSpawner.instance = this;
    }
}
