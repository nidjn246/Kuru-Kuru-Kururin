using UnityEngine;
using UnityEngine.Audio;

public class AllMusic : MonoBehaviour
{
    public AudioSource winsound;
    private void Start()
    {
        //Put the audiosource into the winsound variable
        winsound = GetComponent<AudioSource>();
        //make it so it doesnt stop when switching scenes
        DontDestroyOnLoad(gameObject);
    }

    //when this is called play the sound when you win a level
    public void StartLevelWinMusic()
    {
        winsound.Play();
    }
}
