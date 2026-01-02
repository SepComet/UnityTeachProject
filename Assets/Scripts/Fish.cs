using UnityEngine;

/// <summary>
/// Day4：2D 刚体系统，触发器部分，刚体进入触发器
/// </summary>
public class Fish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name + " has entered Fish");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.name + " stay in Fish");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.name + " has exited Fish");
    }
}