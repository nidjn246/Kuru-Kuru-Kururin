using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;

    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
     HP health;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        health = FindObjectOfType<HP>();
    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        m_Rigidbody.rotation += rotationSpeed;

        if (Input.GetAxis("Horizontal") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, speed));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -speed));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health.RemoveHealth();
     }
}
