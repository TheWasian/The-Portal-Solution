using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LightPathChange : MonoBehaviour
{
    public Material matBlue;
    public Material matOrange;

    private void Start()
    {
        GetComponent<Renderer>().material = matBlue;
    }

    private void Update()
    {
        if (buttontrigger.exitTrigger == true)
        {
            GetComponent<Renderer>().material = matOrange;
        }
    }
}
