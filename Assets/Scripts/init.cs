using UnityEngine;
using UnityEngine.SceneManagement;

public class init : MonoBehaviour
{
    void Awake()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
