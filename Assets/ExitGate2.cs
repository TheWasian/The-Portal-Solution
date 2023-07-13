using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGate2 : MonoBehaviour
{
    public Animator anim;


    private void Update()
    {
        if (ButtonTrigger3.exitTrigger == true)
        {
            if (ButtonTrigger25.exitTrigger == true)
            {
                Debug.Log("Cool BEans");
                anim.SetBool("near", true);
            }
                
        }
    }
}
