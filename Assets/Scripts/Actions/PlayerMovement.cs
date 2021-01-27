 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class PlayerMovement : MonoBehaviour 
 {
    public float moveSpeed = 3.0f;
    public float jumpSpeed = 0.5f;
    public float gravity = 2f;

    private CharacterController _characterController;
    private Vector3 _direction;

    private bool PlayerJumped => _characterController.isGrounded && Input.GetKey(KeyCode.Space);
     
    // Use this for initialization
    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
     
     // Update is called once per frame
     void FixedUpdate () {
         
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Set movement and direction
        Vector3 inputDirection = new Vector3(horizontal, 0f, vertical);
        Vector3 transformDirection = transform.TransformDirection(inputDirection);
        Vector3 strafeMovement = moveSpeed * Time.deltaTime * transformDirection;

        _direction = new Vector3(strafeMovement.x, _direction.y, strafeMovement.z);

        // Modify Y axis by player jump
        if (PlayerJumped)
        {
            _direction.y = jumpSpeed;
        }
        else if (_characterController.isGrounded)
        {
            _direction.y = 0f;
        }
        else
        {
            _direction.y -= gravity * Time.deltaTime;
        }

        _characterController.Move(_direction);
    }
 }