using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : Interactable
{
    public GameObject ThreeDPrinterObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        ThreeDPrinterObject.GetComponent<ThreeDPrinterController>().Interact();
    }

    public override void DeInteract()
    {
        ThreeDPrinterObject.GetComponent<ThreeDPrinterController>().DeInteract();
    }
}
