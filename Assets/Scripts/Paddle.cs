using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool autoPlay;

    private Ball ball;
    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }
    private void Update()
    {
        if (!autoPlay)
        {
            float mousePositionInBlocks = Input.mousePosition.x / Screen.width * 16;
            transform.position = new Vector3(Mathf.Clamp(mousePositionInBlocks, 0.5f, 15.5f), transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(ball.transform.position.x + 0.49f, transform.position.y, transform.position.z);
        }
    }

}
