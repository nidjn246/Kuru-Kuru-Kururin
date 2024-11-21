using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    int respawnLocationX = 0;
    int respawnLocationY = 0;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        m_Rigidbody.rotation += 1.5f;

        if (Input.GetAxis("Horizontal") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(5, 0));
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, 5));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-5, 0));
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -5));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_Rigidbody.linearVelocity = Vector2.zero;
        transform.position = new Vector2 (respawnLocationX, respawnLocationY);
    }
}
