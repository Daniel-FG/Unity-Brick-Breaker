using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static float maxHorizontalSpeed = 10f;
    public static float maxVerticalSpeed = 10f;

    private Paddle paddle;
    private Rigidbody2D rigidBody;
    private Vector3 paddleToMouse;
    private bool hasStarted = false;

    private void Awake()
    {
        paddle = FindObjectOfType<Paddle>();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        paddleToMouse = transform.position - paddle.transform.position;
    }
    private void Update()
    {
        if (!hasStarted)
        {
            transform.position = paddle.transform.position + paddleToMouse;
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                rigidBody.velocity = new Vector2((transform.position.x - maxHorizontalSpeed), maxVerticalSpeed);
            }
        }
    }
}
