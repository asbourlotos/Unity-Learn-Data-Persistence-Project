using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;

public class LoadGameRank : MonoBehaviour
{
    // Fields to display the player info:
    public Text BestPlayerName;

    // Static variables for holding the best player data:
    private static int BestScore;
    private static String BestPlayer;

    // Awake method:
    private void Awake()
    {
        LoadGameRankData();
    }

    // Set Best Player Method:
    private void SetBestPlayer()
    {
        if (BestPlayerName == null && BestScore == 0)
        {
            BestPlayerName.text = "";
        }
        else
        {
            BestPlayerName.text = $"Best Score - {BestPlayer}: {BestScore}";
        }
    }

    // Load Game Rank Method:
    public void LoadGameRankData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            BestPlayer = data.TheBestPlayer;
            BestScore = data.HighestScore;
            SetBestPlayer();
        }
    }

    [System.Serializable] class SaveData
    {
        public int HighestScore;
        public string TheBestPlayer;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
