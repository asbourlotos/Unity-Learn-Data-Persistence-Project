using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandler : MonoBehaviour
{
    // Static Class for saving the current player data
    // Singleton pattern
    public static PlayerDataHandler Instance;
    public string PlayerName;
    public int Score;
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
