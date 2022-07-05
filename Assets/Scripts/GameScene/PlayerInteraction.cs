using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float InteractionDistance;
    public LayerMask InteractionMask;
    public Camera PlayerCam;

    private void Update()
    {
        Debug.DrawRay(PlayerCam.transform.position, PlayerCam.transform.forward * InteractionDistance);
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckForInteraction();
        }
    }

    public void CheckForInteraction()
    {
        RaycastHit ray;
        if (Physics.Raycast(PlayerCam.transform.position, PlayerCam.transform.forward, out ray, InteractionDistance, InteractionMask))
        {
            InteractableObject interactableObject = ray.collider.gameObject.GetComponent<InteractableObject>();
            if (interactableObject != null)
            {
                interactableObject.Interact();
            }
        }
    }
}