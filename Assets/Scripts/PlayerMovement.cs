using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameObject однозначно имеет компонент Rigidbody и Animator
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    [SerializeField]
    private float jumpForce;
    public float speed;
    private bool isJumping;
    [SerializeField]
    private Transform leftPoint;
    [SerializeField]
    private Transform rightPoint;


    void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody>();
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.position = Vector3.Lerp(transform.position, rightPoint.position, speed * Time.deltaTime);
                return;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, leftPoint.position, speed * Time.deltaTime);
                return;
            }
        }
    }

    private void FixedUpdate()
    {
        if((Input.GetAxis("Jump") != 0 || Input.GetAxis("Vertical") > 0) && !isJumping)
        {
            playerRigidbody.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
            isJumping = true;
            playerAnimator.SetTrigger("jumpStart");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
