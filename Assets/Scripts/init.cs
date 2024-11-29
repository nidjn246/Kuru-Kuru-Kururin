using UnityEngine;
using UnityEngine.SceneManagement;

public class init : MonoBehaviour
{
    //when the game starts go to main menu
    void Awake()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
