using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected float speed = 2f;
    [SerializeField] protected Vector3 targetPosition;
    private void FixedUpdate()
    {
        this.GetTargetPosition();
        this.LookAtTarget();
        Moving();
    }

    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPosition, this.speed*Time.fixedDeltaTime);
        transform.parent.position = newPos;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x)*Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
    protected virtual void GetTargetPosition()
    {
        targetPosition = InputManager.Instance.MousePosition;
        targetPosition.z = 0;
    }
}
