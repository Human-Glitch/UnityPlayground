using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    [field: SerializeField]
    public int Health { get; set; }

    [field: SerializeField]
    public bool IsGrounded { get; set; } 

    void Awake()
    {
        
        Health = 10;
    }

    public void Rotate()
    {
        //Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        //characterController.Move(transform.TransformDirection(mouseInput * playerSpeed * Time.deltaTime));
    }
}
