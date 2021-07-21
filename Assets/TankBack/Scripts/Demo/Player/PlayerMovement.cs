using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed;
    public float speed;

    public GameObject fire;
    public GameObject bullet;

    private float horizontal;
    private float vertical;

    private bool isAttack;

    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire"))
        {
            isAttack = true;
        }
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
        Attack();
    }

    private void Move()
    {
        Vector3 movement = transform.forward * vertical * speed * Time.deltaTime;
        m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
    }
    
    private void Turn()
    {
        float turn = horizontal * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
    }
    
    private void Attack()
    {
        if (isAttack)
        {
            Instantiate(bullet, fire.transform.position, fire.transform.rotation);
            isAttack = false;
        }
    }

}
