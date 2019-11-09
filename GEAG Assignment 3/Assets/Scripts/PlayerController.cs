using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float interactRadius = 5;
    GameObject selectedObject;
    bool canSelect = true;
    GameObject buttonObject = null;
    public GameObject cursor;
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
        Vector3 headPosition = Camera.main.transform.position;
        Vector3 aimDirection = Camera.main.transform.forward;

        RaycastHit hitinfo;
        if (Input.GetKeyDown(KeyCode.F) && ThreeDPrinterController.printingInProgress == false)
        {
            if (Physics.Raycast(headPosition, aimDirection, out hitinfo, interactRadius) && canSelect == true)
            {
                print(hitinfo.collider.name);

                if (hitinfo.collider != null && hitinfo.transform.gameObject.GetComponent<Interactable>() != null)
                {
                    hitinfo.transform.gameObject.GetComponent<Interactable>().Interact();
                    selectedObject = hitinfo.transform.gameObject;
                    canSelect = false;
                }
               
            }
            else if (canSelect == false)
            {
                selectedObject.GetComponent<Interactable>().DeInteract();
                canSelect = true;
            }

        }

        if(Physics.Raycast(headPosition, aimDirection, out hitinfo, interactRadius))
        {
            if(hitinfo.collider.gameObject.GetComponent<InteractableButtons>() != null)
            {
                //cursor.GetComponent<SphereCollider>().enabled = true;
                cursor.transform.position = hitinfo.point;
            }
           
        }
    }
}
