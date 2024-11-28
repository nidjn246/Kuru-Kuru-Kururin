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
        health = FindFirstObjectByType<HP>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {

        //rotate the rigidbody to the right
        m_Rigidbody.rotation += rotationSpeed;

        Vector2 currentVelocity = m_Rigidbody.linearVelocity;
        currentVelocity += new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        currentVelocity.x = Mathf.Clamp(currentVelocity.x, -10f, 10f);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, -10f, 10f);

        m_Rigidbody.linearVelocity = currentVelocity;
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
