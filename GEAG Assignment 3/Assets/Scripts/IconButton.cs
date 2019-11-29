using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconButton : InteractableButtons
{
    
    bool hasAnimated = false;

    public GameObject objectToShow;
    public GameObject objectToPrint;
   
    public GameObject ConfigMenuObj;
    // Start is called before the first frame update
    void Start()
    {
        Init();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public override void OnHover()
    {
        if (hovering == false)
        {
            objectToShow.SetActive(true);
            animator.SetTrigger("Select");
            hovering = true;
        }
    }

    public override void DeHover()
    {
        if (hovering == true)
        {
            objectToShow.SetActive(false);
            animator.SetTrigger("DeSelect");
            hovering = false;
        }
    }

    public override void OnClick()
    {
        ShowConfigurations();
        ConfigMenuObj.GetComponent<ConfigController>().ObjectToPrint = objectToPrint;
    }

    public void ShowConfigurations()
    {
        ConfigMenuObj.SetActive(true);
        ConfigMenuObj.GetComponent<Animator>().SetTrigger("ShowConfig");
        foreach (IconButton button in FindObjectsOfType<IconButton>())
        {
            if (button.gameObject != gameObject)
            {
                button.gameObject.SetActive(false);
            }
        }
    }
}
