using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispenserLogic : MonoBehaviour
{

    public static bool dTrigger = false;

    private void Update()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        if (dTrigger == true)
        {
            this.GetComponent<MeshCollider>().enabled = false;
            yield return new WaitForSeconds(1);
            this.GetComponent<MeshCollider>().enabled = true;
        }
    }
}
