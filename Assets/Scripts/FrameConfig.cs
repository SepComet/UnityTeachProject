using UnityEngine;

public class FrameConfig : MonoBehaviour
{
    [SerializeField] private int _targetFrameRate = 120;

    private void Update()
    {
        Application.targetFrameRate = _targetFrameRate;
    }
}