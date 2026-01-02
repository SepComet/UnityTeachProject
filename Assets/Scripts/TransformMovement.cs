using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
        CheckKeyInput(KeyCode.A);
        CheckKeyInput(KeyCode.W);
        CheckKeyInput(KeyCode.D);
        CheckKeyInput(KeyCode.S);


        CheckMouseInput(0);
        CheckMouseInput(1);
        CheckMouseInput(2);
    }

    /// <summary>
    /// Day3：Transform.Translate() 位移方法，直接修改坐标
    /// </summary>
    private void Move()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        //this.transform.Translate(_speed * Time.deltaTime * input);
        // 不乘 Time.deltaTime 的位移
        this.transform.Translate(_speed * input);
    }

    /// <summary>
    /// Day3：读取输入演示，对于四个方向键的输入进行检测
    /// </summary>
    /// <param name="keycode"></param>
    private void CheckKeyInput(KeyCode keycode)
    {
        if (Input.GetKeyDown(keycode))
        {
            Debug.Log(keycode + "按下");
        }

        if (Input.GetKeyUp(keycode))
        {
            Debug.Log(keycode + "抬起");
        }

        if (Input.GetKey(keycode))
        {
            Debug.Log(keycode + "按住");
        }
    }

    /// <summary>
    /// Day3：获取鼠标输入
    /// </summary>
    /// <param name="keycode">0表示鼠标左键，1表示鼠标右键，2表示鼠标中键</param>
    private void CheckMouseInput(int keycode)
    {
        if (Input.GetMouseButtonDown(keycode))
        {
            Debug.Log(keycode + "按下");
        }

        if (Input.GetMouseButton(keycode))
        {
            Debug.Log(keycode + "按住");
        }

        if (Input.GetMouseButtonUp(keycode))
        {
            Debug.Log(keycode + "松开");
        }
    }
}