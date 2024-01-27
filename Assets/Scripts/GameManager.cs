using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField playerName;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (DataPersistence.instance != null)
        {
            highScoreText.text = $"Best Score : {DataPersistence.instance.highScorePlayerName} : {DataPersistence.instance.highScore}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void SaveName()
    {
        if (DataPersistence.instance != null)
        {
            DataPersistence.instance.SavePlayerName(playerName.text);
        }

    }
}
