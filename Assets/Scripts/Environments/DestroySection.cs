using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySection : MonoBehaviour
{
    public string parentName;

    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());

    }

    IEnumerator DestroyClone ()
    {
        yield return new WaitForSeconds(100);
        if (parentName == "StartSection(Clone)" )
        {
            yield return new WaitForSeconds(30);
            Destroy(gameObject);
        }
    }
}
