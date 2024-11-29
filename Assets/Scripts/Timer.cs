using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Timertext;
    [SerializeField] float time;
    void Start()
    {
        //reset the timer when you start the game and put 
        resetTimer();
        DontDestroyOnLoad(gameObject);
    }

    public void resetTimer()
    {
        //make a scene variable so that you can use that in the code
        Scene scene = SceneManager.GetActiveScene();

        //if you are at level .. make the timer ..seconds
        if (scene.name == "Level 1")
        {
            time = 60;
        }
        else if (scene.name == "Level 2")
        {
            time = 90;
        }
        else if (scene.name == "Level 3")
        {
            time = 120;
        }
    }

    void Update()
    {
        //make the timer count down with deltatime
        time = time - Time.deltaTime;

        //change the text on screen to match the timer
        Timertext.text = "Time: " + Mathf.Round(time); 

        //if the time = 0 go to the game over screen
        if (time <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
