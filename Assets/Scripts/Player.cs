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

        //get the HP script
        health = FindObjectOfType<HP>();
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
        health.RemoveHealth();
     }
}
