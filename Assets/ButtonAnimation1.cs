using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation1 : MonoBehaviour
{
    public Animator anim;


    private void Update()
    {
        if (ButtonTrigger3.exitTrigger == true)
        {
            //sends a public bool
            anim.SetBool("pressed", true);
        }
    }
}
