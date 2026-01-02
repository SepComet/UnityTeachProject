using System;
using UnityEngine;

/// <summary>
/// Day1：生命周期函数测试
/// </summary>
/// <remarks>
/// <para><b>各个生命周期函数执行时机</b>:
/// <list type="bullet">
/// <item>Awake: 脚本刚被实例化时就调用，即使它的 enabled == false</item>
/// <item>Start: 脚本被启用的第一帧调用</item>
/// <item>Update: 每个游戏帧调用一次</item>
/// <item>FixedUpdate: 每个固定帧调用一次（可在项目设置里修改）</item>
/// </list>
/// </para>
/// </remarks>
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

    /// <summary>
    /// 1 tick 的时长是 100ns，可根据这个来展示 Update 频率会发生变化，而 FixedUpdate 的频率基本稳定
    /// </summary>
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

    /// <summary>
    /// 每个游戏帧的最后调用 LateUpdate
    /// </summary>
    private void LateUpdate()
    {
        
    }

    /// <summary>
    /// 当脚本的 enabled 由 false->true 时调用
    /// </summary>
    private void OnEnable()
    {
        
    }

    /// <summary>
    /// 当脚本的 enabled 由 true->false 时调用
    /// </summary>
    private void OnDisable()
    {
        
    }

    /// <summary>
    /// 当脚本销毁时在销毁前调用
    /// </summary>
    private void OnDestroy()
    {
        
    }
}