using System;
using UnityEngine;

namespace Assets.Scripts.Configs
{
    [CreateAssetMenu(menuName = "Movement/Settings", fileName = "MovementData")]
    public class MovementSettings : ScriptableObject
    {
        [SerializeField] private float _moveSpeed = 3.0f;
        [SerializeField] private float _jumpSpeed = 0.5f;
        [SerializeField] private float _gravity = 2f;

        public float MoveSpeed { get { return _moveSpeed; } }
        public float JumpSpeed { get { return _jumpSpeed; } }
        public float Gravity { get { return _gravity; } }
    }
}
