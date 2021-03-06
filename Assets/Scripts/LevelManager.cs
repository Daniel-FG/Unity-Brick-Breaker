﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;  //Get build index and increment
        SceneManager.LoadScene(nextLevelIndex);
    }
    
    public void BrickDestroyed()
    {
        print(Brick.levelTotalBricks);
        if(Brick.levelTotalBricks <= 0)
        {
            LoadNextLevel();
        }
        
    }
}
