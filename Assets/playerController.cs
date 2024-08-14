using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 2f;
    public float jumpForce = 5f; // Add jump force
    Rigidbody rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input checks for actions
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump"); // Trigger jump animation
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Apply jump force
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("strike"); // Trigger strike animation
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("block"); // Trigger block animation
        }
    }

    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed;

        if (translation != 0)
        {
            animator.SetInteger("move", 1);
        }
        else
        {
            animator.SetInteger("move", 0);
        }

        transform.Translate(0, 0, translation * speed * Time.deltaTime);
        transform.Rotate(0, rotation * rotationSpeed * Time.deltaTime, 0);
    }
}
