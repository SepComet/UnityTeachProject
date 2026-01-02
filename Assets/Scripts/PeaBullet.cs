using UnityEngine;

public class PeaBullet : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    /// <summary>
    /// Day1：Range 标签可以让变量在 Inspector 中以滑块的形式进行调整
    /// </summary>
    [Range(0f, 30f)] [SerializeField] private float _rotateSpeed = 2f;

    private void Start()
    {
        // Day6：使用两个参数的 Destroy 重载来自动化销毁子弹对象，也可以用在控制对象播放完死亡动画后再进行销毁
        Destroy(this.gameObject, 10f);
    }

    private void Update()
    {
        // Day1：通过改变 Z 轴来对游戏对象进行旋转，记得要乘上 Time.deltaTime，让旋转速度不受帧率变化
        this.transform.Rotate(new Vector3(0, 0, _rotateSpeed * Time.deltaTime));

        this.transform.Translate(_moveSpeed * Time.deltaTime * Vector3.right);
    }
}