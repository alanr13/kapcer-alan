using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
