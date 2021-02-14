using UnityEngine;

namespace Inputs
{
    public class PlayerInput : MonoBehaviour
    {
        public Vector3 Direction { get; set; }

        public Vector3 Rotation {get; set;}

        private void Update()
        {
            Direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            Rotation = new Vector3(0f, Input.GetAxis("Mouse X"), 0f);
        }
    }
}
