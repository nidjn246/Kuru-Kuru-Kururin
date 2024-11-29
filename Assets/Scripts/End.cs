using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    AllMusic music;
    Timer timer;
    

    private void Start()
    {
        //take the allmusic and timer script and use them here
        music = FindFirstObjectByType<AllMusic>();
        timer = FindFirstObjectByType<Timer>();
    }

    //when you hit a trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the scene = level 3 go to the win screen
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            SceneManager.LoadScene("Win Screen");
        }
        //else go 1 scene further
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            music.StartLevelWinMusic();
        }
        
        //and reset the timer everytime
        timer.resetTimer();
    }
}
