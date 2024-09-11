using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MyMonoBehaviour
{
    protected static GameCtrl instance;
    public static GameCtrl Instance { get => instance;}
    [SerializeField] protected Camera mainCamera;
    public Camera MainCamera {get => this.mainCamera;}

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log("Only 1 GameCtrl allow");
        GameCtrl.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCamera != null ) return;
        mainCamera = Transform.FindObjectOfType<Camera>();
        Debug.Log(transform.name + ": Load Camera", gameObject);
    }
}
