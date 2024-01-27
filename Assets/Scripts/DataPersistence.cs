using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence instance;

    public string playerName;
    public string highScorePlayerName;
    public int highScore;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
    }

    public void SavePlayerName(string name)
    {
        playerName = name;
    }

    public void UpdateHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            highScorePlayerName = playerName;
        }

        SaveHighScore();
    }

    void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.SetString("HighScorePlayerName", highScorePlayerName);
        PlayerPrefs.Save();
    }

    void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScorePlayerName = PlayerPrefs.GetString("HighScorePlayerName", "");
    }
}
