using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource bgmusic;

    private void Awake ()
    {
        //put the background music source into the bgmusic variable
        bgmusic = GetComponent<AudioSource>();
        //play it on Awake
        bgmusic.Play();
        //make it so it wont go away when switching scenes
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        //if the scene is gameover or win screen pauze the music
        if (SceneManager.GetActiveScene().name == "Game Over" || SceneManager.GetActiveScene().name == "Win Screen")
        {
            bgmusic.Pause();
        }

        //if the scene is level selector or main menu start it again
        if (SceneManager.GetActiveScene().name == "Level Selector" || SceneManager.GetActiveScene().name == "Main Menu")
        {
            bgmusic.UnPause();
        }
    }
}
