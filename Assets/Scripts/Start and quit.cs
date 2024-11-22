using UnityEngine;
using UnityEngine.SceneManagement;

public class Startandquit : MonoBehaviour
{

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Kuru Kuru Kururin");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
