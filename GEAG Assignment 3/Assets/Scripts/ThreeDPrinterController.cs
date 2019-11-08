using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDPrinterController : Interactable
{
    bool HasFocus;
    PlayerController player;
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
        /*Camera.main.transform.parent = null;
        cameraOriginalPosition = Camera.main.transform;
        cameraOriginalPosition.position = Camera.main.transform.position;
        cameraOriginalPosition.rotation = Camera.main.transform.rotation;

        Camera.main.transform.position = cameraViewPosition.position;
        Camera.main.transform.rotation = cameraViewPosition.rotation;
        player.gameObject.GetComponent<FPSController>().enabled = false;*/

        base.Interact();
    }

    public override void DeInteract()
    {
        animator.SetTrigger("TurnOff");
        base.DeInteract();
        /*Camera.main.transform.parent = player.transform;
        Camera.main.transform.position = Vector3.zero;
        Camera.main.transform.rotation = cameraOriginalPosition.rotation;
        player.gameObject.GetComponent<FPSController>().enabled = true;*/
    }
}
