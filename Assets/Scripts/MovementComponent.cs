using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (_rigidbody != null)
        {
            _rigidbody.velocity = input * _speed;
        }
        else
        {
            transform.Translate(_speed * Time.deltaTime * input);
            //transform.Translate(_speed * input);
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("鼠标左键按下");
        }
    }
}