using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer instance = null;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("Duplicated Music Player Destroyed");
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
