using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string escenaJuego;
    public string tutorial;

    public void StartGame()
    {
        SceneManager.LoadScene(escenaJuego);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(tutorial);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
