using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviorUsingCharacterContrioller : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    public CharacterController cc;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cc.Move(move * movementSpeed * Time.deltaTime);


        //Transition from moving moving animation to Idle
        if(move != Vector3.zero)
           animator.SetBool("IsMoving", true);
        else
            animator.SetBool("IsMoving", false);

        //Transition from moving forward(Run) to Idle
        if (Vector3.Dot(transform.forward, move) > 0)
            animator.SetBool("IsMovingForward", true);
        else
            animator.SetBool("IsMovingForward", false);

        //Transition from moving bacwards(Run_Back) animation to Idle
        if (Vector3.Dot(-transform.forward, move) > 0)
            animator.SetBool("IsMovingBackward", true);
        else
            animator.SetBool("IsMovingBackward", false);

        //Transition from moving right(Right) animation to Idle
        if (Vector3.Dot(transform.right, move) > 0)
            animator.SetBool("IsMovingRight", true);
        else
            animator.SetBool("IsMovingRight", false);

        //Transition from moving left(Left) animation to Idle
        if (Vector3.Dot(-transform.right, move) > 0)
            animator.SetBool("IsMovingLeft", true);
        else
            animator.SetBool("IsMovingLeft", false);
    }
}
