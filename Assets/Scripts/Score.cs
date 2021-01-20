using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]int score = 0;
    [SerializeField]int hiScore = 0;
    [SerializeField]Text scoreText;
    [SerializeField]Text hiScoreText;
    
    

    void Start()
    {
        Set();
        LoadHiScore();
    }

    public void Add(int amt = 1)
    {
        score += amt;
        UpdateScoreDisplay();
    }

    public void Set(int amt = 0)
    {
        score = amt;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        scoreText.text = score.ToString();
    }

    public void LoadHiScore()
    {
      hiScore = PlayerPrefs.GetInt("hiscore");
      UpdateHiScoreDisplay();
    }

    public void SaveHiScore()
    {
        PlayerPrefs.SetInt("hiscore", hiScore);
        UpdateHiScoreDisplay();
    }

    public void UpdateHiScoreDisplay()
    {
        hiScoreText.text = hiScore.ToString();
    }

    public void CheckForNewHiScore()
    {
        if (score > hiScore)
        {
            hiScore = score;
            SaveHiScore();
        }
            
    }


}
