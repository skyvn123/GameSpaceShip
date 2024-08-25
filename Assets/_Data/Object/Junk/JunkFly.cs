using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ObjectFly
{
    [SerializeField] protected float minCamPos=-5f;
    [SerializeField] protected float maxCamPos=5f;
    protected override void ResetValue()
    {
        base.ResetValue();
        this.speed = 3f;
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        this.GetFlyDirection();
    }
    protected virtual void GetFlyDirection()
    {
        Vector3 camPos = GameCtrl.Instance.MainCamera.transform.position;
        Vector3 objPos = transform.parent.position;
        camPos.x += Random.Range(this.minCamPos,this.maxCamPos);
        camPos.y += Random.Range(this.minCamPos,this.maxCamPos);
        camPos.z = 0;
        this.direction = camPos-objPos;
        this.direction.Normalize();
        float rot_z = Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f,0f,rot_z);
        Debug.DrawLine(objPos,objPos+direction*7,Color.red,Mathf.Infinity);
    }
}
