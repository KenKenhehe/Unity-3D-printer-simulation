using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : InteractableButtons
{
    GameObject objectToPrint;
    public GameObject configObj;
    IconButton[] icons;
    public Color idleColor;
    public Color hoverColor;
    // Start is called before the first frame update
    void Start()
    {
        icons = FindObjectsOfType<IconButton>();
        GetComponent<SpriteRenderer>().color = idleColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnHover()
    {
        if (hovering == false)
        {
            GetComponent<SpriteRenderer>().color = hoverColor;
            hovering = true;
        }
    }

    public override void DeHover()
    {
        if (hovering == true)
        {
            GetComponent<SpriteRenderer>().color = idleColor;
            hovering = false;
        }
    }


    public override void OnClick()
    {
        configObj.SetActive(false);

        foreach (IconButton button in icons)
        {
            if (button.gameObject != gameObject)
            {
                button.gameObject.SetActive(true);
            }
        }
    }
}
