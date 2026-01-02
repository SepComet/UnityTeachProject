using UnityEngine;

public class FrameConfig : MonoBehaviour
{
    [SerializeField] private int _targetFrameRate;

    private void Update()
    {
        Application.targetFrameRate = _targetFrameRate;
    }
}