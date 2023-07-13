using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAnimation : MonoBehaviour
{
    public Animator anim;


    private void Update()
    {
        if (buttontrigger.exitTrigger == true)
        {
            //sends a public bool
            anim.SetBool("pressed", true);
        }
    }
}
