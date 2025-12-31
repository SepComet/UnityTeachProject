using System;
using UnityEngine;
using UnityEngine.Pool;

public class MeowGenerator : MonoBehaviour
{
    [SerializeField] private Transform _generateTransform;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _parent;
    private GameObject[] _pool;
    private int _currObjIndex = 0;

    private void Start()
    {
        _pool = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            _pool[i] = GameObject.Instantiate(_prefab, _parent);
            _pool[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = _generateTransform.position;
            Vector3 screenPos = _camera.WorldToScreenPoint(worldPos);
            var obj = _pool[_currObjIndex++ % 10];
            obj.SetActive(true);
            obj.transform.position = screenPos;
        }
    }
}