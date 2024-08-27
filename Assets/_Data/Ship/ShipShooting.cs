using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShipShooting : MyMonoBehaviour
{

    [SerializeField] protected bool isShooting;
    [SerializeField] protected float shootTimer;
    [SerializeField] protected float shootDelay = 0.2f;
    [SerializeField] protected float BarrelTime = 0.2f;
    [SerializeField] protected List<Transform> shipflames;

    protected override void LoadComponents()
    {
        shootTimer = shootDelay;
        this.LoadBarrel();
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            this.Shooting();
        }
        this.GunbarrelFire();
    }

    protected virtual void Shooting()
    {
        this.shootTimer += Time.fixedDeltaTime;
        if (!isShooting) return;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bullet_1,this.transform.position, this.transform.rotation);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
        Debug.Log("Shooting ==== "+newBullet.name);
        BarrelTime = 0.5f;
        shipflames[0].gameObject.SetActive(true);
    }

    protected virtual void GunbarrelFire()
    {
        this.BarrelTime -= Time.fixedDeltaTime;
        if (this.BarrelTime > 0) return;
        shipflames[0].gameObject.SetActive(false);
    }
    protected virtual void LoadBarrel()
    {
        if (this.shipflames.Count > 0) return;
        foreach (Transform shipflame in this.transform)
        {
            this.shipflames.Add(shipflame);
            shipflame.gameObject.SetActive(false);
        }
        Debug.Log(transform.name + " Load shipflame Prefab");
    }
}
