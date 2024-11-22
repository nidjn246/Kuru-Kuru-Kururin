using UnityEngine;
using UnityEngine.SceneManagement;

public class Startandquit : MonoBehaviour
{
    //quit the game when the button is pressed
    public void QuitTheGame()
    {
        Application.Quit();
    }

    //Start the game when the button is pressed
    public void StartGame()
    {
        SceneManager.LoadScene("Kuru Kuru Kururin");
    }

    //Go to the main menu when the button is pressed
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
