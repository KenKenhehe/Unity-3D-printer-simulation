using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableButtons : MonoBehaviour
{
    bool hovering = false;
    bool hasAnimated = false;
    public Transform printerTransform;
    public GameObject objectToShow;
    public GameObject objectToPrint;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        printerTransform = GameObject.FindGameObjectWithTag("printerTransform").transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 headPosition = Camera.main.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
        Vector3 aimDirection = Camera.main.transform.forward;
        RaycastHit hitinfo;

        if (Physics.Raycast(headPosition, aimDirection, out hitinfo, 5) && hitinfo.collider.gameObject == gameObject)
        {
            //print(hitinfo.collider.gameObject.GetComponent<InteractableButtons>() == null);
            OnHover();
            print(hitinfo.collider.gameObject);
        }
        else
        {
            DeHover();
        }*/
    }

    public void OnHover()
    {
        if (hovering == false)
        {
            objectToShow.SetActive(true);
            animator.SetTrigger("Select");
            hovering = true;
        }
    }

    public void DeHover()
    {
        if (hovering == true)
        {
            objectToShow.SetActive(false);
            animator.SetTrigger("DeSelect");
            hovering = false;
        }
    }

    public void OnClick()
    {
        if (ThreeDPrinterController.printingInProgress == false)
        {
            Instantiate(objectToPrint, printerTransform.position, Quaternion.identity);
            objectToShow.SetActive(false);
        }
    }

    public void ShowConfigurations()
    {

    }

    public void StartPrint()
    {

    }
}
