using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDPrinterController : Interactable
{
    public static bool printingInProgress = false;

    bool HasFocus;
    PlayerController player;

    [HideInInspector]
    public bool turnON = false;
    public Transform cameraViewPosition;
    public Transform cameraOriginalPosition;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Interact()
    {
        animator.SetTrigger("TurnOn");
        turnON = true;
        base.Interact();
    }

    public override void DeInteract()
    {
        animator.SetTrigger("TurnOff");
        turnON = false;
        base.DeInteract();
    }
}
