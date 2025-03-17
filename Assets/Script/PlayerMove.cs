using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float walkSpeed = 6.0f; 
    public float sprintSpeed = 12.0f; 
    public float gravity = -9.8f; 
    public float jumpForce = 5.0f; 

    private float currentSpeed; 
    private CharacterController characterController;
    private float verticalVelocity;
    private bool isGrounded;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        if (characterController == null)
        {
            Debug.LogError("CharacterController is NULL");
        }

        currentSpeed = walkSpeed; 
    }

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * currentSpeed;
        float deltaZ = Input.GetAxis("Vertical") * currentSpeed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = transform.TransformDirection(movement);

        isGrounded = characterController.isGrounded;

        if (isGrounded)
        {
            verticalVelocity = -1f; 

            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

        movement.y = verticalVelocity;

        characterController.Move(movement * Time.deltaTime);
    }
}
