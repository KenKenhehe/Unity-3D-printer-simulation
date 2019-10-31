using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float interactRadius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InteractWithObj();
    }

    void InteractWithObj()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Collider[] interactables = Physics.OverlapSphere(transform.position, interactRadius);
            if (interactables[0] != null)
            {
                interactables[0].GetComponent<Interactable>().Interact();
            }
        }
    }
}
