using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }


    public TMP_Text scoreText;

    public int bestScore = 0;

    public TMP_Text _bestText;
    void Start()
    {
        scoreText.text = "Score : " + 0;

        bestScore = PlayerPrefs.GetInt("HighScore", 0);

        _bestText.text = "Best :" + bestScore;

    }

    public void UpdateScore(int playerScore)
    {
        scoreText.text = "Score :" + playerScore;
    }


    public void CheckForBestScore(int playerScore)
    {
        if (playerScore > bestScore)
        {
            bestScore = playerScore;
            PlayerPrefs.SetInt("HighScore", bestScore);
            _bestText.text = "Best :" + bestScore;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
