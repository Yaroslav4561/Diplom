using System.Collections;
using UnityEngine;

public class PersonMo : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = this.GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator is missing on the GameObject!");
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsMovingForward", true);
        }
        else
        {
            animator.SetBool("IsMovingForward", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("IsMovingBackward", true);
        }
        else
        {
            animator.SetBool("IsMovingBackward", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("IsMovingLeft", true);
        }
        else
        {
            animator.SetBool("IsMovingLeft", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsMovingRight", true);
        }
        else
        {
            animator.SetBool("IsMovingRight", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("IsJump", true);
        }
        else
        {
            animator.SetBool("IsJump", false);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) 
        {
            animator.SetBool("IsRunForward", true);
        }
        else
        {
            animator.SetBool("IsRunForward", false);
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunRight", true);
        }
        else
        {
            animator.SetBool("IsRunRight", false);
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunLeft", true);
        }
        else
        {
            animator.SetBool("IsRunLeft", false);
        }
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunBackward", true);
        }
        else
        {
            animator.SetBool("IsRunBackward", false);
        }
    }
}
