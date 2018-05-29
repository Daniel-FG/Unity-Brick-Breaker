using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Vector2 fallingSpeed = Vector2.zero;
    
    private Rigidbody2D rigidBody = null;
    private PolygonCollider2D polygonCollider2D;
    private LevelManager levelManager;
    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        rigidBody = GetComponent<Rigidbody2D>();
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        rigidBody.velocity = Vector2.zero;
        polygonCollider2D.isTrigger = true;
        rigidBody.velocity = fallingSpeed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            levelManager.LoadLevel("Lose");
            //rigidBody.velocity = Vector2.zero;
        }
    }
}
