using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(menuName = "Movement/Settings", fileName = "MovementData")]
    public class MovementSettings : ScriptableObject
    {
        [SerializeField] private float _moveSpeed = 3.0f;
        [SerializeField] private float _jumpSpeed = 0.5f;
        [SerializeField] private float _gravity = 2f;

        public float MoveSpeed => _moveSpeed;
        public float JumpSpeed => _jumpSpeed;
        public float Gravity => _gravity;
    }
}
