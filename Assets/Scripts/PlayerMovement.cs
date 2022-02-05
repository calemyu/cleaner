using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        //Camera.main.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * movementSpeed * Time.deltaTime);

        // if(Input.GetButtonDown("Jump") && IsGrounded()){
        //     velocity.y = 10f;
        // }
        
    }
    
    // bool IsGrounded(){
    //     return Physics.CheckSphere(groundCheck.position, .1f, ground);
        

    // }
    
}
