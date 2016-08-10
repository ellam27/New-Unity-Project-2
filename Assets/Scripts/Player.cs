using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    private bool grounded = false;
    public float JumpSpeed;
   

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Move left");
            transform.RotateAround(transform.position, transform.up, -2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Move right");
            transform.RotateAround(transform.position, transform.up, 2);
        }
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Move up");
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Move down");
            rb.AddForce(-transform.forward * speed);
        }
        if (grounded == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(transform.up * JumpSpeed, ForceMode.VelocityChange);
            }
        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.collider.tag == "Ground")
        {
            grounded = true;
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.collider.tag == "Ground")
        {
            grounded = false;
        }
    }
  
}
