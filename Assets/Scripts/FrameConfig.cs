using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameConfig : MonoBehaviour
{
    [SerializeField] private int _targetFrameRate;

    void Start()
    {
        Application.targetFrameRate = _targetFrameRate;
    }
}