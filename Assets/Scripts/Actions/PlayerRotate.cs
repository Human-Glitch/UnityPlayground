using Assets.Scripts.Configs;
using Assets.Scripts.Inputs;
using Assets.Scripts.Interfaces;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerRotate : MonoBehaviour, IRotate
{
    [SerializeField] private RotateSettings _rotateSettings;

    private PlayerInput _playerInput;

    /// <summary>
    /// Injected Rotate Settings
    /// </summary>
    public RotateSettings RotateSettings 
    {
        get
        {
            return _rotateSettings;
        }
    }

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }
    
    void FixedUpdate()
    {
        Vector3 rotationInput = _playerInput.Rotation;
        transform.Rotate(Time.deltaTime * RotateSettings.TurnSpeed * rotationInput);
    }
}
