using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField]
    private float _turnSpeed;

    private void Awake()
    {
        _turnSpeed = 100f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mouseInput = new Vector3(0, Input.GetAxis("Mouse X"), 0);

        transform.Rotate(Time.deltaTime * _turnSpeed * mouseInput);
    }
}
