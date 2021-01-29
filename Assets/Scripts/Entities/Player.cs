using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICharacter
{
    [field: SerializeField]
    public int Health { get; set; }

    [field: SerializeField]
    public bool IsGrounded { get; set; } 

    void Awake()
    {
        Health = 10;
    }
}
