using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void OnReturnButtonClick()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
