using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private int MovementSpeed = 1500;
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        rb.useGravity = true;
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = true;
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
          
            rb.velocity = new Vector3(0, 0, MovementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            rb.useGravity = true;
                   
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
           
            rb.velocity = new Vector3(MovementSpeed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0f, 90f, 0f);
            rb.useGravity = true;

        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
           
            rb.velocity = new Vector3(-MovementSpeed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0f, -90f, 0f);
            rb.useGravity = true;
        }
    
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
            
            rb.velocity = new Vector3(0, 0, -MovementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
            rb.useGravity = true;
        }
    }

  

}
