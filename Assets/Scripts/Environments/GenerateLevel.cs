using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject [] roadSection;
    public int zPos = 278;
    public bool creatingSection = false;
    public int secNum;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(roadSection[secNum], new Vector3(-57,-8,zPos), Quaternion.identity);
        zPos += 139;
        yield return new WaitForSeconds(2);
        creatingSection=false;
    }
}
