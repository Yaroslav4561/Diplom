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
        // Рух вперед
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsMovingForward", true);
        }
        else
        {
            animator.SetBool("IsMovingForward", false);
        }

        // Рух назад
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("IsMovingBackward", true);
        }
        else
        {
            animator.SetBool("IsMovingBackward", false);
        }
        // Рух ліворуч
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("IsMovingLeft", true);
        }
        else
        {
            animator.SetBool("IsMovingLeft", false);
        }
        // Рух праворуч
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsMovingRight", true);
        }
        else
        {
            animator.SetBool("IsMovingRight", false);
        }
        // Стрибок
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("IsJump", true);
        }
        else
        {
            animator.SetBool("IsJump", false);
        }
        // Біг вперед
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) 
        {
            animator.SetBool("IsRunForward", true);
        }
        else
        {
            animator.SetBool("IsRunForward", false);
        }
        // Біг вправо
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunRight", true);
        }
        else
        {
            animator.SetBool("IsRunRight", false);
        }
        // Біг вліво
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunLeft", true);
        }
        else
        {
            animator.SetBool("IsRunLeft", false);
        }
        // Біг назад
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
