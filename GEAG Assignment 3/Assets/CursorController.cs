using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnCollisionEnter(Collision collision)
    {
        print("Collide");
        if (collision.gameObject.GetComponent<InteractableButtons>() != null)
        {
            print("Collide");
            collision.gameObject.GetComponent<InteractableButtons>().OnHover();
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<InteractableButtons>() != null)
        {
            collision.gameObject.GetComponent<InteractableButtons>().DeHover();
        }
    }
}
