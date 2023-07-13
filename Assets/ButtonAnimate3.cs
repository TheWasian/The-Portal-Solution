using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimate3 : MonoBehaviour
{
    public Animator anim;


    private void Update()
    {
        if (ButtonTrigger25.exitTrigger == true)
        {
            //sends a public bool
            anim.SetBool("pressed", true);
        }
    }
}
