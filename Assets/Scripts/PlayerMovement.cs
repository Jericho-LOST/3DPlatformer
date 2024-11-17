using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
  [SerializeField]  float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground; // asigns layer option to the inspector 
    [SerializeField] float mouseSensitivity = 100f;
    float xRotation = 0f;
    [SerializeField] Transform playerCamera; //asigns camera to inspector 
 

    void Start()
    {
      rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; //it locks the curser...

    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //clamps vertical rotation
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //rotates camera up and down
        transform.Rotate(Vector3.up * mouseX); //Rotate player left/right

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        //move in direction the player is facing 
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput; 
        rb.velocity = new Vector3 (moveDirection.x * movementSpeed, rb.velocity.y, moveDirection.z * movementSpeed);


        rb.velocity = new Vector3 (horizontalInput* movementSpeed, rb.velocity.y, verticalInput *movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3 (rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
    bool IsGrounded()
    { return Physics.CheckSphere(groundCheck.position, 1f, ground); }

}
