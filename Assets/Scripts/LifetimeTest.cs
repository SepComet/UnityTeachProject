using System;
using UnityEngine;

public class LifetimeTest : MonoBehaviour
{
    private long _lastUpdateTick;
    private long _lastFixedUpdateTick;

    private void Awake()
    {
        Debug.Log("Awake" + DateTime.Now.Ticks);
    }

    void Start()
    {
        Debug.Log("Start" + DateTime.Now.Ticks);
    }

    void Update()
    {
        Debug.Log("Update tick offset" + (DateTime.Now.Ticks - _lastUpdateTick));
        _lastUpdateTick = DateTime.Now.Ticks;
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate tick offset" + (DateTime.Now.Ticks - _lastFixedUpdateTick));
        _lastFixedUpdateTick = DateTime.Now.Ticks;
    }
}