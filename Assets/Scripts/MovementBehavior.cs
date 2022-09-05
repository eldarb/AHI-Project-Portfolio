using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalAxis, 0, verticalAxis) * movementSpeed * Time.deltaTime;
        Vector3 newPosisiton = rb.position + rb.transform.TransformDirection(movement);
        rb.MovePosition(newPosisiton);
    }
}
