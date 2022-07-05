using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnimator;
    private bool animatorBoolState = true;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    public void UseDoor()
    {
        doorAnimator.SetBool("IsOpen", animatorBoolState);
        animatorBoolState = !animatorBoolState;
    }
}