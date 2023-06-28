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
        //sets default colour to matBlue
        GetComponent<Renderer>().material = matBlue;
    }

    private void Update()
    {
        if (buttontrigger.exitTrigger == true)
        {
            //if the exitTrigger is true then the material will change to orange
            GetComponent<Renderer>().material = matOrange;
        }
    }
}
