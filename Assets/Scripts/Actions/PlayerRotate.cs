using Configs;
using Inputs;
using Interfaces;
using UnityEngine;

namespace Actions
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(RotateSettings))]
    public class PlayerRotate : MonoBehaviour, IRotate
    {
        [SerializeField] private RotateSettings _rotateSettings;

        private PlayerInput _playerInput;

        /// <summary>
        /// Injected Rotate Settings
        /// </summary>
        public RotateSettings RotateSettings => _rotateSettings;

        private void Awake()
        {
            _playerInput = GetComponent<PlayerInput>();
        }

        private void FixedUpdate()
        {
            Vector3 rotationInput = _playerInput.Rotation;
            transform.Rotate(Time.deltaTime * RotateSettings.TurnSpeed * rotationInput);
        }
    }
}


