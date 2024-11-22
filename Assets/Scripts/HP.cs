using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI HealthPoints;
   [SerializeField] public int Hp;
    void Start()
    {
        Hp = 3;

        HealthPoints.text = "Health: " + Hp;
    }

    public void RemoveHealth()
    {
        if (Hp > 1)
        {
            Hp = Hp - 1;

            HealthPoints.text = "Health: " + Hp;

        }

        else
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
