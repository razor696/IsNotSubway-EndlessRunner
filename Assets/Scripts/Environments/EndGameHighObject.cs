using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameHighObject : MonoBehaviour
{
    public void EndGameNow()
    {
        SceneManager.LoadScene(2);
    }
}
