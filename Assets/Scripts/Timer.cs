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
        resetTimer();
        DontDestroyOnLoad(gameObject);
    }

    public void resetTimer()
    {
        Scene scene = SceneManager.GetActiveScene();
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
        time = time - Time.deltaTime;
        Timertext.text = "Time: " + Mathf.Round(time); 

        if (time <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
