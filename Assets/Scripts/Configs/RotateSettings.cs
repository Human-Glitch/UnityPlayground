using UnityEngine;

namespace Assets.Scripts.Configs
{
    [CreateAssetMenu(menuName = "Rotate/Settings", fileName = "RotateData")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _turnSpeed = 100f;

        public float TurnSpeed { get { return _turnSpeed; } }
        
    }
}