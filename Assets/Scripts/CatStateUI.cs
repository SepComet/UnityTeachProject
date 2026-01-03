using UnityEngine;
using UnityEngine.UI;

public class CatStateUI : MonoBehaviour
{
    [SerializeField] private Transform _parent;
    [SerializeField] private float _yOffset;
    [SerializeField] private Camera _camera;

    private void LateUpdate()
    {
        Vector3 worldPos = _parent.position;
        worldPos.y += _yOffset;
        Vector3 screenPos = _camera.WorldToScreenPoint(worldPos);
        transform.position = screenPos;
    }
}
