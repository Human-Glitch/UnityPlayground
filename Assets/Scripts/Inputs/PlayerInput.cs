using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Inputs
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
