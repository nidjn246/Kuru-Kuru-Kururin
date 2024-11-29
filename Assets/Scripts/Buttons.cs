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
        SceneManager.LoadScene("Level Selector");
    }

    //Go to the main menu when the button is pressed
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //start level 1
    public void Level1Start()
    {
        SceneManager.LoadScene("Level 1");
    }
    //start level 2
    public void Level2Start()
    {
        SceneManager.LoadScene("Level 2");
    }
    //start level 3
    public void Level3Start()
    {
        SceneManager.LoadScene("Level 3");
    }
}
