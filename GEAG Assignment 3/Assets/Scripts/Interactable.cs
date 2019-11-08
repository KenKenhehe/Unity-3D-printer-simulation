using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool InteractOnce = true;
    public bool HasInteracted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Interact()
    {
        print("Interact");
    }

    public virtual void DeInteract()
    {
        print("disable interaction");
    }
}
