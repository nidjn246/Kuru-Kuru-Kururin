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
        //if Hp is lower then ... deactivate the gameobject/icon of the heart
        if (Hp < 1)
        {
            Heartsobjects[0].SetActive(false);
        }
        else
        {
            Heartsobjects[0].SetActive(true);
        }

        if (Hp < 2)
        {
            Heartsobjects[1].SetActive(false);
        }
        else
        {
            Heartsobjects[1].SetActive(true);
        }

        if (Hp < 3)
        {
            Heartsobjects[2].SetActive(false);
        }
        else
        {
            Heartsobjects[2].SetActive(true);
        }
    }
}
