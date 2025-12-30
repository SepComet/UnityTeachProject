using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _shootCd = 3.0f;
    [SerializeField] private Transform _bulletSpawn;
    private float _shootTimer;

    private void Update()
    {
        _shootTimer += Time.deltaTime;
        if (_shootTimer > _shootCd)
        {
            GameObject bullet = Instantiate(_bulletPrefab, _bulletSpawn.position, Quaternion.identity);
            _shootTimer = 0;
        }
    }
}