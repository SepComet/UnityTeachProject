using UnityEngine;

public class PeaBullet : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    [Range(0f, 30f)]
    [SerializeField] private float _rotateSpeed = 20f;

    private void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    private void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, _rotateSpeed  * Time.deltaTime));
        this.transform.position += _moveSpeed * Time.deltaTime * Vector3.right;
    }
}