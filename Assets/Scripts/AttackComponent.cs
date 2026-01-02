using UnityEngine;

/// <summary>
/// Day1：豌豆射手的攻击脚本
/// </summary>
public class AttackComponent : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _shootCd = 3.0f;
    [SerializeField] private Transform _bulletSpawn;
    private float _shootTimer;

    /// <summary>
    /// Day1：直接写在 Update 里的计时
    /// </summary>
    private void Update()
    {
        _shootTimer += Time.deltaTime;
        if (_shootTimer > _shootCd)
        {
            GameObject.Instantiate(_bulletPrefab, _bulletSpawn.position, Quaternion.identity);
            _shootTimer = 0;
        }
    }
}