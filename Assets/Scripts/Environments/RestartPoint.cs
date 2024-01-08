using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPoint : MonoBehaviour
{

    public void RestartPointCoin()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        ScoreManager.scoreCount = 0;
    }
}
