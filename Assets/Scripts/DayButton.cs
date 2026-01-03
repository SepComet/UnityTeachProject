using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TMPro.TextMeshProUGUI _text;

    void Start()
    {
        _button.onClick.AddListener(() => SceneManager.LoadScene(_text.text));
    }
}