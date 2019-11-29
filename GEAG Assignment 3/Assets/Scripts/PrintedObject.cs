using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintedObject : Interactable
{
    bool hasGrab = false;
    GameObject transformToAttach;
    Rigidbody rb;
    bool OnPrinter;

    // Start is called before the first frame update
    void Start()
    {
        transformToAttach = GameObject.FindGameObjectWithTag("ObjectTransform");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        GetComponent<Rotator>().enabled = false;
        Grab(transformToAttach);
    }

    public override void DeInteract()
    {
        Drop();
    }

    public void Grab(GameObject transformToAttach)
    {
        rb.isKinematic = true;
        transform.position = transformToAttach.transform.position;
        transform.parent = transformToAttach.transform;
        hasGrab = true;

    }
    public void Drop()
    {
        rb.isKinematic = false;
        transform.parent = null;
        hasGrab = false;
    }
}
