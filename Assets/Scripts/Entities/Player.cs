using Interfaces;
using UnityEngine;

namespace Entities
{
    public class Player : MonoBehaviour, ICharacter
    {
        [field: SerializeField]
        public int Health { get; set; }

        [field: SerializeField]
        public bool IsGrounded { get; set; }

        private void Awake()
        {
            Health = 10;
        }
    }
}
