using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown5;
    public GameObject countDown4;
    public GameObject countDown3;
    public GameObject countDown2;   
    public GameObject countDown1;
    public GameObject countDown0;
    public GameObject countDownGo;
    public GameObject Fade;
    public AudioSource ready;
    public AudioSource leggo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }
    
    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countDown5.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1f);
        countDown4.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1f);
        countDown3.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1f);
        countDown0.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1f);
        countDownGo.SetActive(true);
        leggo.Play();
        PlayerMovement.canMove = true;
    }
    void Update()
    {
        
    }
}
