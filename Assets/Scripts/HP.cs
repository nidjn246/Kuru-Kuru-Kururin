using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    [SerializeField] public int Hp;
    [SerializeField] public GameObject[] Heartsobjects;
    void Start()
    {
        //set hp to 3
        Hp = 3;
    }

    public void RemoveHealth()
    {
        //if Hp is bigger then 1 remove 1 hp
        if (Hp > 1)
        {
            Hp = Hp - 1;
        }

        //else load the game over screen
        else
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    private void Update()
    {
        if (Hp < 1)
        {
            Heartsobjects[0].SetActive(false);
        }

        if (Hp < 2)
        {
            Heartsobjects[1].SetActive(false);
        }

        if (Hp < 3)
        {
            Heartsobjects[2].SetActive(false);
        }
    }
}
