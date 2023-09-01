using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float shakeAmount = 0.1f;
    public float shakeSpeed = 50f;

    private Vector2 moveDirection;
    private bool isMoving = false;
    private Animator anim;

    // Update is called once per frame
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        ProcessInput();
        Move();

        if(isMoving)
        {
            Shake();
        }
    }

    private void ProcessInput()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
            moveY = 1f;
        if (Input.GetKey(KeyCode.S))
            moveY = -1f;
        if (Input.GetKey(KeyCode.A))
            moveX = -1f;
        if (Input.GetKey(KeyCode.D))
            moveX = 1f;

        moveDirection = new Vector2(moveX, moveY).normalized;

        isMoving = (moveX != 0 || moveY != 0);
    }

    private void Move()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void Shake()
    {
           float yOffset = Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
           transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
    }

    private void StopAnim()
    {
        anim.enabled = false;
    }
}
