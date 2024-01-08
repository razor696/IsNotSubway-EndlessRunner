using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject thePlayer;


    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<BoxCollider>().enabled = false;
        FindObjectOfType<EndGameLowObject>().EndGameNow();
        FindObjectOfType<EndGameHighObject>().EndGameNow();
    }
}
