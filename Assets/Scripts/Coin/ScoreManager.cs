using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public static int scoreCount;
    public static int highScoreCount;
    public PlayerMovement playerMovement;
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetInt("HighScore");
        }
       
    }

    void Update()
    {
        if (playerMovement == false)
        {
            if (scoreCount > highScoreCount)
            {
                highScoreCount = scoreCount;
                PlayerPrefs.SetInt("HighScore", highScoreCount);
            }
            scoreText.text = "Score: " + Mathf.Round(scoreCount);
            highScoreText.text = "HighScore: " + highScoreCount;
        }
        else
        {
            if (playerMovement == true)
            {
                SceneManager.LoadScene(1);
                scoreText.text = "Score: 0";
            }
        }
    }
}
