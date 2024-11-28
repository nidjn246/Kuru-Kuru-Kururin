using UnityEngine;
using UnityEngine.Audio;

public class AllMusic : MonoBehaviour
{
    public AudioSource winsound;
    private void Start()
    {
        winsound = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    public void StartLevelWinMusic()
    {
        winsound.Play();
    }
}
