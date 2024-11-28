using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    AllMusic music;
    Timer timer;
    

    private void Start()
    {
        music = FindFirstObjectByType<AllMusic>();
        timer = FindFirstObjectByType<Timer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            SceneManager.LoadScene("Win Screen");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            music.StartLevelWinMusic();
        }
        
        
        timer.resetTimer();
    }
}
