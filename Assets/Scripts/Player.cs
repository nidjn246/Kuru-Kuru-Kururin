using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //all the variables that are used in this script
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

    private void FixedUpdate()
    {

        //rotate the rigidbody to the right
        m_Rigidbody.rotation += rotationSpeed;

        //get the current velocity that is used and put it into the currentvelocity
        Vector2 currentVelocity = m_Rigidbody.linearVelocity;

        //if a movement key is pressed make the linearvelocity go up
        currentVelocity += new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        //keep the speed/drag in between -10 and 10
        currentVelocity.x = Mathf.Clamp(currentVelocity.x, -10f, 10f);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, -10f, 10f);

        //put the velocity into the currentVelocity variable
        m_Rigidbody.linearVelocity = currentVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            //Call this function when the player hits the wall
            if (audioSource != null)
            {
                audioSource.Play();
            }

            //get where the contact point is
            ContactPoint2D cp = collision.GetContact(0);

            //get the normal of the contact point
            Vector2 dir = cp.normal;
            
            //return the force so you bounce back
            m_Rigidbody.linearVelocity = dir * bounciness;
            
            //remove 1 heart when you collide with the wall
            health.RemoveHealth();
        
    }

    //when you hit a trigger collider reset the Hp
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health.Hp = 3;
    }
}
