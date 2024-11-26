using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
   [SerializeField] private AudioClip winsound;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        AudioSource.PlayClipAtPoint(winsound, transform.position, 1f);
    }
}
