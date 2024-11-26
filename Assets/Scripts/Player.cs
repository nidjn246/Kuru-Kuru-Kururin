using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;

    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float bounciness = 20f;

    HP health;
    private AudioSource audioSource;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

        //get the HP script
        health = FindObjectOfType<HP>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {

        //rotate the rigidbody to the right
        m_Rigidbody.rotation += rotationSpeed;

        //when the key D is pressed go to the right
        if (Input.GetAxis("Horizontal") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        }

        //when the key W is pressed go up
        if (Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, speed), ForceMode2D.Force);
        }

        //when the key A is pressed go to the left
        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
        }

        //when the key S is pressed go down
        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -speed), ForceMode2D.Force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            //Call this function when the player hits the wall
            if (audioSource != null)
            {
                audioSource.Play();
            }

            ContactPoint2D cp = collision.GetContact(0);

            Vector2 dir = cp.normal;

            m_Rigidbody.linearVelocity = dir * bounciness;//(m_Rigidbody.linearVelocity * 10f) * -1;

            health.RemoveHealth();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health.Hp = 3;
    }
}
