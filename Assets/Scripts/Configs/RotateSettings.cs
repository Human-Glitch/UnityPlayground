using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(menuName = "Rotate/Settings", fileName = "RotateData")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _turnSpeed = 100f;

        public float TurnSpeed => _turnSpeed;
    }
}