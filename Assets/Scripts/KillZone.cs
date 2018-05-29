using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private LevelManager levelManager;
    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            levelManager.LoadLevel("Lose");
            Brick.levelTotalBricks = 0;
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
