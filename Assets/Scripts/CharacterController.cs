using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8;
    void Update()
    {
       transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))* moveSpeed * Time.deltaTime;
    }
}
