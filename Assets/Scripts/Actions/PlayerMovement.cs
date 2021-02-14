using Configs;
using Inputs;
using Interfaces;
using UnityEngine;

namespace Actions
{
    /// <summary>
    /// Player Movement Class that calculates the xyz positions of the player 
    /// based on player inputs and movement settings.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(MovementSettings))]
    public class PlayerMovement : MonoBehaviour, IMovement
    {
        private CharacterController _characterController;
        private PlayerInput _playerInput;
        private Vector3 _direction;

        [SerializeField] private MovementSettings _movementSettings;

        /// <summary>
        /// Flags when the player is grounded based on the character controller value.
        /// </summary>
        [SerializeField] private bool IsGrounded => _characterController.isGrounded;

        /// <summary>
        /// Injected Movement Settings
        /// </summary>
        public MovementSettings MovementSettings => _movementSettings;

        private bool PlayerJumped => IsGrounded && Input.GetKey(KeyCode.Space);

        // Use this for initialization
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _playerInput = GetComponent<PlayerInput>();
        }
     
        // Update is called once per frame
        private void FixedUpdate () 
        {
            // Set movement and direction
            Vector3 inputDirection = _playerInput.Direction;
            Vector3 transformDirection = transform.TransformDirection(inputDirection);
            Vector3 strafeMovement = MovementSettings.MoveSpeed * Time.deltaTime * transformDirection;

            _direction = new Vector3(strafeMovement.x, _direction.y, strafeMovement.z);

            // Modify Y axis by player jump
            if (PlayerJumped)
            {
                _direction.y = MovementSettings.JumpSpeed;
            }
            else if (IsGrounded)
            {
                _direction.y = 0f;
            }
            else
            {
                _direction.y -= MovementSettings.Gravity * Time.deltaTime;
            }

            _characterController.Move(_direction);
        }
    }
}