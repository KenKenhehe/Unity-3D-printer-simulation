using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float interactRadius = 5;
    GameObject selectedObject;
    public bool canSelect = true;
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
        Vector3 headPosition = Camera.main.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
        Vector3 aimDirection = Camera.main.transform.forward;

        RaycastHit hitinfo;
        if (Input.GetKeyDown(KeyCode.F) && ThreeDPrinterController.printingInProgress == false)
        {
            if (Physics.Raycast(headPosition, aimDirection, out hitinfo, interactRadius) && canSelect == true)
            {
                //print(hitinfo.collider.gameObject.GetComponent<Interactable>() != null);
                if (hitinfo.collider != null && hitinfo.collider.gameObject.GetComponent<Interactable>() != null)
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
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(headPosition, aimDirection, out hitinfo, interactRadius) )
            {
                if (hitinfo.collider != null && hitinfo.collider.gameObject.GetComponent<Interactable>() != null)
                {
                    Instantiate(hitinfo.collider.gameObject, 
                        hitinfo.collider.gameObject.transform.position + new Vector3(1, 0, 1), 
                        Quaternion.identity);
                }
            }
        }


        if (Physics.Raycast(headPosition, aimDirection, out hitinfo, interactRadius))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hitinfo.collider.gameObject.GetComponent<InteractableButtons>() != null)
                {
                    hitinfo.collider.gameObject.GetComponent<InteractableButtons>().OnClick();
                }
            }
        }

        if (Physics.Raycast(headPosition, aimDirection, out hitinfo, interactRadius))
        {
            if (hitinfo.collider.gameObject.GetComponent<InteractableButtons>() != null)
            {
                cursor.transform.position = hitinfo.point;
            }
        }
    }
}
