using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public UnityEvent InteractionEvent;

    public virtual void Interact()
    {
        if (InteractionEvent != null)
        {
            InteractionEvent.Invoke();
        }
    }
}