using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource bgmusic;

    private void Awake ()
    {
        bgmusic = GetComponent<AudioSource>();
        bgmusic.Play();
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game Over" || SceneManager.GetActiveScene().name == "Win Screen")
        {
            bgmusic.Pause();
        }

        if (SceneManager.GetActiveScene().name == "Level Selector" || SceneManager.GetActiveScene().name == "Main Menu")
        {
            bgmusic.UnPause();
        }
    }
}
