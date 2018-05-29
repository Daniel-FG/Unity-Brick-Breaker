using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public static int levelTotalBricks = 0;
    public Sprite[] hitSprites;

    private int timesHit;
    private LevelManager levelManager;
    private bool isBreakable;
    
    private void Start()
    {
        isBreakable = (tag == "Breakable");
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
        if(isBreakable)
        {
            levelTotalBricks++;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isBreakable)
            {
                HandleHits();
            }
        }
    }
    void HandleHits()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            levelTotalBricks--;
            Destroy(gameObject);
            levelManager.BrickDestroyed();
        }
        else
        {
            int spriteIndex = timesHit - 1;
            if (hitSprites[spriteIndex])
            {
                GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
            }
        }
    }
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
