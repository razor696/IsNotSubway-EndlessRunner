using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinsound;

    private void OnTriggerEnter(Collider other) 
    {
        coinsound.Play();
        this.gameObject.SetActive(false);
        Destroy(gameObject);
        ScoreManager.scoreCount += 1;
    }
    public void RestartPointCoin()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        ScoreManager.scoreCount = 0;
    }
}


