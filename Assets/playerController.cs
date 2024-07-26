using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 2f;
    Rigidbody rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void FixedUpdate()
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
